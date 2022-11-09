using ATM;

namespace ATMGui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ATMachine atm1 = new();
            List<Cardholder> cardHolders = new List<Cardholder>();
            Cardholder person1 = new("12345678", 1234, "Jakob", "Kjeldsteen", 1000);
            Cardholder person2 = new("22222222", 2222, "Mark", "Drongesen", 1000);
            Cardholder person3 = new("33333333", 3333, "Rasmus", "Gudiksen", 1000);
            Cardholder person4 = new("44444444", 4444, "Emil", "TP", 1000);
            Cardholder person5 = new("55555555", 5555, "Christian", "Funder", 1000);
            cardHolders.Add(person1);
            cardHolders.Add(person2);
            cardHolders.Add(person3);
            cardHolders.Add(person4);
            cardHolders.Add(person5);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2(cardHolders));
        }
    }
}