using System.Text;
using CarRental.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Dependency Injection
builder.Services.AddScoped<IAuthService, AuthService>();

// 🔹 CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// 🔹 Controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });

    // 🔹 Servers (your API base URLs)
    opt.AddServer(new OpenApiServer { Url = "https://localhost:7028" });
    opt.AddServer(new OpenApiServer { Url = "http://localhost:7028" });

    // 🔹 JWT Bearer definition
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter JWT token with Bearer prefix (e.g., 'Bearer eyJhbGci...')",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });


    // 🔹 Apply both auth schemes
    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        },
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="oauth2"
                }
            },
            new[] { "read:user", "user:email" }
        }
    });
});

// 🔹 Database
builder.Services.AddDbContext<CarDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarRentalDbConnection"));
});

// 🔹 JWT Authentication
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                builder.Configuration["JwtSettings:SecretKey"]))
        };
    })

    // 🔹 GitHub OAuth
    .AddCookie("Cookies")
    .AddOAuth("GitHub", options =>
    {
        options.ClientId = "Ov23liaQwdNspLyAKYsb";
        options.ClientSecret = "8f665bffd001c97fcf07fea92f98be791a24d476";
        options.CallbackPath = new PathString("/signin-github"); // Must match GitHub App settings

        options.AuthorizationEndpoint = "https://github.com/login/oauth/authorize";
        options.TokenEndpoint = "https://github.com/login/oauth/access_token";
        options.UserInformationEndpoint = "https://api.github.com/user";

        options.SaveTokens = true;

        options.ClaimActions.MapJsonKey("urn:github:login", "login");
        options.ClaimActions.MapJsonKey("urn:github:id", "id");
        options.ClaimActions.MapJsonKey("urn:github:url", "html_url");
    });

var app = builder.Build();

// 🔹 Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
