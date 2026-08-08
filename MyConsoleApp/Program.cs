using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

Console.WriteLine($"Environment: {appSettings.EnvironmentName}");
Console.WriteLine($"Greeting: {appSettings.Greeting}");

public sealed class AppSettings
{
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
}
