namespace ExceptionApp2;

class Program
{
    static int EvaluateExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
        {
            throw new ArgumentException("Expression cannot be empty.");
        }

        string[] parts = expression.Split('*');
        int result = 1;

        foreach (string part in parts)
        {
            if (!int.TryParse(part, out int number))
            {
                throw new ArgumentException($"Invalid number: {part}");
            }
            result *= number;
        }

        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string expression to evaluate:");
        string input = Console.ReadLine();
        try
        {
            int result = EvaluateExpression(input);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}