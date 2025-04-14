namespace ExceptionApp2
{
    internal class StringToInt
    {
        private string _input;
        public StringToInt(string input)
        {
            this._input = input;
        }
        public void Convert()
        {
            try
            {
                Console.WriteLine(_input.GetType());
                int result = int.Parse(_input);
                Console.WriteLine(result);
                Console.WriteLine(result.GetType());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != '1' && input[i] != '0')
                {
                    input = null;
                }
            }
            if (input != null)
            {
                StringToInt operation = new StringToInt(input);
                operation.Convert();
            }
            else
            {
                Console.WriteLine("No input provided");
            }
        }
    }
}