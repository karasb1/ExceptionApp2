namespace ExceptionApp2
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Credit_card card1 = new Credit_card();
                card1.SetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    internal class Credit_card
    { 
        private string card_number;
        private string name;
        private int cvc;
        private string expiration_date;
        public Credit_card()
        {
            card_number = "";
            name = "";
            cvc = 0;
            expiration_date = "";
        }
        public Credit_card(string card_number, string name, int cvc, string expiration_date)
        {
            this.card_number = card_number;
            this.name = name;
            this.cvc = cvc;
            this.expiration_date = expiration_date;
        }
        public string Card_number
        {
            get { return card_number; }
            set { card_number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Cvc
        {
            get { return cvc; }
            set { cvc = value; }
        }
        public string Expiration_date
        {
            get { return expiration_date; }
            set { expiration_date = value; }
        }
        public void SetAll()
        {
            Console.WriteLine("Enter card number: ");
            card_number = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter cvc: ");
            cvc = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter expiration date: ");
            expiration_date = Console.ReadLine() ?? string.Empty;
        }
        public void SetAll(string card_number, string name, int cvc, string expiration_date)
        {
            this.card_number = card_number;
            this.name = name;
            this.cvc = cvc;
            this.expiration_date = expiration_date;
        }
    }
}