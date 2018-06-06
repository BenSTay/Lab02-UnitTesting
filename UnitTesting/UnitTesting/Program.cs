using System;

namespace BankApp
{
    public class Program
    {
        // This method gets a yes or no input from the user.
        static bool YesOrNo()
        {
            // This loops until either "Y" or "N" is entered by the user.
            while (true)
            {
                Console.Write("Do you want another transaction? (Y/N): ");
                switch (Console.ReadLine().ToUpper())
                {
                    case "Y": return true;
                    case "N": return false;
                    default: Console.WriteLine("Invalid Input. Please enter either Y or N.");
                        break;
                }
            }
        }

        // This method handles menu navigation.
        static int ChooseOption()
        {
            int choice;

            // This loops until a number between 1 and 3 is entered by the user.
            while (true)
            {
                try
                {
                    Console.Write("Choose an option: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 4 && choice > 0)
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Number should be between 1 and 3.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input. Please enter a number.");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }

        // This method displays the user's balance formatted as currency.
        static void ViewBalance(decimal balance)
        {
            string balanceStr = String.Format("{0:C}", balance);
            Console.WriteLine($"Your current balance is: {balanceStr}\n");
        }

        // This method removes a specified amount of money from the user's balance if the money is able to be taken out.
        public static decimal WithdrawMoney(decimal balance, decimal moneyWithdrawn)
        {
            if (moneyWithdrawn <= balance)
            {
                return balance -= moneyWithdrawn;
            }
            else
            {
                throw new Exception("You can't withdraw more money than is in your account!");
            }
        }

        // This method adds a specified amount of money from the user's balance.
        public static decimal AddMoney(decimal balance, decimal moneyAdded)
        {
            return balance += moneyAdded;
        }

        // This method gets the amount of money to be added/subtracted from the user.
        static decimal GetAmount()
        {
            decimal amount;

            // This loops until a valid decimal is entered by the user.
            while (true)
            {
                try
                {
                    Console.Write("Amount: $");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    if (amount > 0)
                    {
                        return amount;
                    }
                    else
                    {
                        Console.WriteLine("Amount must be positive!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input.\n");
                }
            }
        }

        // This method runs the bank application.
        static decimal MainMenu(decimal balance)
        {
            Console.WriteLine("\nChoose a transaction:\n1: View Balance\n2: Withdraw Money\n3: Add Money\n");
            switch (ChooseOption())
            {
                case 1: ViewBalance(balance);
                    return balance;
                case 2:
                    try
                    {
                        return WithdrawMoney(balance, GetAmount());
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return balance;
                    }
                    finally
                    {
                        Console.WriteLine();
                    }
                case 3: return AddMoney(balance, GetAmount());

                //This code should never be run, but is here just in case.
                default: Console.WriteLine("Something went wrong!");
                    return balance;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ben's Bank!");
            decimal balance = 5000.00M;

            // The application is run until the user enters "N" on the Y/N prompt.
            do
            {
                balance = MainMenu(balance);
            } while (YesOrNo());
        }
    }
}
