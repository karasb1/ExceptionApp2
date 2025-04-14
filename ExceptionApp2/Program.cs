namespace ExceptionApp2;

public class Passport
{
    public string FullName { get; set; }
    public string PassportNumber { get; set; }
    public string Date_Of_Issue { get; set; }

    public Passport(string fullName, string passportNumber, string dateOfIssue)
    {
        if (string.IsNullOrEmpty(fullName))
        {
            throw new ArgumentNullException("Full name cannot be null or empty");
        }
        if (string.IsNullOrEmpty(passportNumber))
        {
            throw new ArgumentNullException("Passport number cannot be null or empty");
        }
        if (string.IsNullOrEmpty(dateOfIssue))
        {
            throw new ArgumentNullException("Date of issue cannot be null or empty");
        }

        if (passportNumber.Length != 9)
        {
            throw new ArgumentException("Passport number must be 9 characters long");
        }
        FullName = fullName;
        PassportNumber = passportNumber;
        Date_Of_Issue = dateOfIssue;
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Passport passport = new Passport("John Doe", "123456789", "2021-10-10");
            Console.WriteLine("Passport created successfully");
            Passport passport2 = new Passport("", "123456789", "2021-10-10");
            Console.WriteLine("Passport created successfully");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}