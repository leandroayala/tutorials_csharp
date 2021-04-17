using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ayala", 1000);
            Console.WriteLine($"Acount {account.Number} was created for {account.Owner} with {account.Balance} initial balance!");
            account.MakeWithDraw(500, DateTime.Now, "rent payment");
            Console.WriteLine($"Saldo: {account.Balance}");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine($"Saldo: {account.Balance}");

            try
            {
                account.MakeWithDraw(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
