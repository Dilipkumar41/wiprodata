namespace JwtExampleDotnet.Models
{
    public class JwtSettings
    {
        public string Issuer { get; internal set; }
        public string Audience { get; internal set; }
        public char[] SecretKey { get; internal set; }
        public double ExpirationMinutes { get; internal set; }
    }
}