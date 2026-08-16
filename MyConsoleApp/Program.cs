using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Configuration.AddUserSecrets<Program>(optional: true, reloadOnChange: true);

var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

Console.WriteLine($"Environment: {appSettings.EnvironmentName}");
Console.WriteLine($"Greeting: {appSettings.Greeting}");
Console.WriteLine($"Password: {appSettings.Password}");
Console.WriteLine($"Max Num: {appSettings.MaxNumber}");

var p = new Person();
p.Id = 100;
p.Age = 25;
p.FirstName = "Ali";
p.LastName = "Ahmad";
p.DateOfBirth = new DateOnly(2008, 1, 1);
p.Nationality = "Jordanian";

Console.WriteLine($"DoB: {p.DateOfBirth}");

public sealed class AppSettings
{
    public string Password { get; set; } = string.Empty;
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
    public int MaxNumber { get; set; }
}
