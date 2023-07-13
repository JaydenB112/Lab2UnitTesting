using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace UnitTesting
{
    public class Program
    {
        public static decimal Balance;
        static void Main(string[] args)
        {

            UserInterface();
        }


        public static void UserInterface()
        {
            bool menuSelect = false;
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Gon make a selection mane.");
            while (menuSelect == false)
            {
                Console.WriteLine("1: Check ur balance");
                Console.WriteLine("2: Withdraw some money");
                Console.WriteLine("3: Deposit some Money");
                Console.WriteLine("4: Exit the ATM");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    decimal result = ViewBalance();
                    Console.WriteLine("$" + result);

                }

                if (input == "2")
                {

                    Console.WriteLine("Aight then Mr/Mrs Moneybags how much?");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    decimal result = Withdraw(amount);
                    Console.WriteLine("Money has been withdrawed..");
                    Console.WriteLine("$" + result);
                }

                if (input == "3")
                {
                    Console.WriteLine("In an economy like this, I get it.");
                    Console.WriteLine("How much would you like to Deposit?");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    decimal result = Deposit(amount);
                    Console.WriteLine("That much richer.");
                    Console.WriteLine("$" + result);
                }

                if (input == "4")
                {
                    menuSelect = true;
                }


            }


        }
        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Your amount is greater than the balance");

            }
            else if (amount == 0)
            {
                throw new Exception("Why are you being dumb");
            }
            else if (amount < 0)
            {
                throw new Exception("You can't withdraw a negative number you absolute DONUT.");
            }
            else
            {
                Balance -= amount;
            }


            return Balance;
        }
        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("How you deposit negative racks? Somebody don't play Monopoly");
            }
            else
            {
                Balance += amount;
            }
            return Balance;
        }
    }
}