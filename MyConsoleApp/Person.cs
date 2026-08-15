public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
}