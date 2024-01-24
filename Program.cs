using System;

class Labsheet07
{
    private static double balance = 1000; // Initial balance

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }

            Console.WriteLine();
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your balance is: ${balance}");
    }

    static void DepositMoney()
    {
        Console.Write("Enter the amount to deposit: $");
        if (double.TryParse(Console.ReadLine(), out double depositAmount) && depositAmount > 0)
        {
            balance += depositAmount;
            Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a valid positive amount.");
        }
    }

    static void WithdrawMoney()
    {
        Console.Write("Enter the amount to withdraw: $");
        if (double.TryParse(Console.ReadLine(), out double withdrawAmount) && withdrawAmount > 0)
        {
            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a valid positive amount.");
        }
    }
}