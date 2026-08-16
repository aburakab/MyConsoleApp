public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public int Age
    {
        get
        {
            // Today: 2026-08-16
            // DOB: 2000-12-10
            var today = DateOnly.FromDateTime(DateTime.Today);

            // Initial age = 26
            var age = today.Year - DateOfBirth.Year;

            // Birthday this year (Dec 10) has not happened yet, 
            // So correct age is 25
            if (DateOfBirth > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
    public string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string Nationality { get; set; } = string.Empty;
    public string PlaceOfBirth { get; set; } = string.Empty;
}