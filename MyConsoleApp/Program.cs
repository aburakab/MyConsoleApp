using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Configuration.AddUserSecrets<Program>(optional: true, reloadOnChange: true);

var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

Console.WriteLine($"Environment: {appSettings.EnvironmentName}");
Console.WriteLine($"Greeting: {appSettings.Greeting}");
Console.WriteLine($"Password: {appSettings.Pasword}");

public sealed class AppSettings
{
    public string Pasword { get; set; } = string.Empty;
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
}
