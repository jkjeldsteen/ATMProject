//using System;
//using ATM;

internal class Program
{
    private static void Main(string[] args)
    {
//        ATMachine atm1 = new();
//        List<Cardholder> cardHolders = new List<Cardholder>();
//        Cardholder person1 = new("12345678", 1234, "Jakob", "Kjeldsteen", 1000);
//        cardHolders.Add(person1);
//        Console.WriteLine("Welcome to Kjeldsteen ATM");
//        Console.WriteLine("Please insert your debit/credit card");
//        string debitCardNum = "";
//        Cardholder currentUser;

//        while (true)
//        {
//            try
//            {
//                debitCardNum = Console.ReadLine();
//                currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
//                if (currentUser != null) { break; }
//                else { Console.WriteLine("Card not recognized. Please try again"); }
//            }
//            catch
//            {
//                { Console.WriteLine("Card not recognized. Please try again"); }
//            }
//        }
//        Console.WriteLine("Please enter your pin: ");
//        int userPin = 0;
//        while (true)
//        {
//            try
//            {
//                userPin = int.Parse(Console.ReadLine());
//                if (currentUser.Pin == userPin) { break; }
//                else { Console.WriteLine("Incorrect PIN!!!. Please try again"); }
//            }
//            catch
//            {
//                { Console.WriteLine("Incorrect PIN!!!. Please try again"); }
//            }
//        }

//        Console.WriteLine("Welcome: " + currentUser.FirstName + currentUser.LastName);
//        int option = 0;
//        do
//        {
//            atm1.printOptions();
//            try
//            {
//                option = int.Parse(Console.ReadLine());
//            }
//            catch (Exception)
//            {

//            }
//            if (option == 1) { atm1.deposit(currentUser); }
//            if (option == 2) { atm1.withdraw(currentUser); }
//            if (option == 3) { atm1.balance(currentUser); }
//            if (option == 4) { break; }
//        }
//        while (option != 4);
//        Console.WriteLine("Thank you! Have a nice day :)");

   }
}