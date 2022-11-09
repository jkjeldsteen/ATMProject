using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATMachine
    {

        public void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        public void deposit(Cardholder currentUser, double amount)
        {
            //Console.WriteLine("How much $$ would you like to deposit?");
            //double deposit = Double.Parse(Console.ReadLine());
            currentUser.Balance += amount;
            //Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.Balance);
        }

        public bool withdraw(Cardholder currentUser, double amount)
        {
            //Console.WriteLine("How much $$ would you like to withdraw?");
            //double withdrawAmount = Double.Parse(Console.ReadLine());
            if(currentUser.Balance >= amount)
            {
                currentUser.Balance -= amount;
                //Console.WriteLine("Withdrawn: " + amount + "Remaining balance: " + currentUser.Balance);
                return true;
            }
            else
            {
                //Console.WriteLine("Not enough $$ in Account: " + currentUser.FirstName);
                return false;
            }
        }

        public double balance(Cardholder currentUser)
        {
            return currentUser.Balance;
        }
    }
}
