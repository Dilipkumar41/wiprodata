using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});


builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "GitHub";
}).AddCookie("Cookies").AddGitHub("GitHub", options =>
{
    options.ClientId = "Ov23lid08n3B7yFV6adb";
    options.ClientSecret = "8f665bffd001c97fcf07fea92f98be791a24d476";
    //options.ClientId = builder.Configuration["Authentication:Google:ClientId"]!;
    //options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;
    options.Scope.Add("user:email");
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGet("/", async (HttpContext context) =>
{
    if (context.User.Identity?.IsAuthenticated ?? false)
    {
        var name = context.User.Identity.Name ?? "Unknown User";
        var email = context.User.Claims.FirstOrDefault(c => c.Type == "email")?.Value ?? "dilip424kumar@gmail.com";
        return Results.Ok($"Hello {name}, How are you? Your email: {email}");
    }
    else
    {
        return Results.Challenge(
            new AuthenticationProperties
            {
                RedirectUri = "/"
            },
            new[] { "GitHub" }
        );
    }
});

app.UseAuthorization();

app.MapControllers();

app.Run();
