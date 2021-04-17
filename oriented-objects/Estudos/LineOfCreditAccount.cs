using System;
namespace classes
{
	public class LineOfCreditAccount : BankAccount
	{
		public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
		{

		}

        public override void PerformMonthEndTransactions()
        {
            if(Balance < 0)
            {
                //Negate the balance to get a positive interest charge:
                var interest = -Balance * 0.07m; //the "m" mean suffixx of type decimal (money)
                MakeWithDraw(interest, DateTime.Now, "Charge montly interest");
            }
        }
    }

}
