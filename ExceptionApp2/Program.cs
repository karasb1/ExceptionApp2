﻿namespace class_2
{
    internal class StringToInt
    {
        private string input;
        public StringToInt(string input)
        {
            this.input = input;
        }
        public void Convert()
        {
            try
            {
                Console.WriteLine(input.GetType());
                int result = int.Parse(input);
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