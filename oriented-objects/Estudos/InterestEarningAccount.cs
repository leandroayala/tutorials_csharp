using System;
namespace classes
{
	public class InterestEarningAccount : BankAccount
	{
		//constructor method based on base class
		public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
		{ 

		}

        //method ovveride from virtual method from bankAccount
        public override void PerformMonthEndTransactions()
        {
           if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthy interest");
            }
        }


    }

}
