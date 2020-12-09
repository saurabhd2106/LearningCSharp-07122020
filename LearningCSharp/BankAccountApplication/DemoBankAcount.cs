using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.BankAccountApplication
{
    public class DemoBankAcount
    {

        static void Main(string[] args)
        {
            BankAccount saurabhAcount = new BankAccount("Saurabh Dhingra", 500);

            Console.WriteLine($"Account : {saurabhAcount.Number} was created for {saurabhAcount.Owner} with initial Deposit as {saurabhAcount.Balance}");

            saurabhAcount.MakeDeposits(200, DateTime.Now, "Second Month saving");

            saurabhAcount.MakeWithdrawals(100, DateTime.Now, "Buying XBox Game");

            Console.WriteLine(saurabhAcount.GetTransactionHistory());

            Console.WriteLine($"Current Balance {saurabhAcount.Balance}" );

            BankAccount chandanAcount = new BankAccount("Chandan", 800);

            Console.WriteLine($"Account : {chandanAcount.Number} was created for {chandanAcount.Owner} with initial Deposit as {chandanAcount.Balance}");
        }

    }
}
