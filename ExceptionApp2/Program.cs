namespace ExceptionApp2;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> numbers = new Dictionary<string, int>
        {
            {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6}, {"seven",7}, {"eight", 8}, {"nine", 9}, {"zero", 0}
        };
        Console.WriteLine("Enter the number in words (one, two, three, four, five, six, seven, eight, nine, zero):");
        string input = Console.ReadLine().ToLower();
        if (numbers.ContainsKey(input))
        {
            int number = numbers[input];
            Console.WriteLine($"Number: {number}");
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}