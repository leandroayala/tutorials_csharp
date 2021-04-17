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

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithDraw(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithDraw(50, DateTime.Now, "buy groceries");
            Console.WriteLine("Perform Month:");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithDraw(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            // How much is too much to borrow?
            lineOfCredit.MakeWithDraw(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithDraw(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
    }
}
