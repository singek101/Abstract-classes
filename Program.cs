using System;

namespace Musediku_michael_week5_lab_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA bankA = new BankA();
            bankA.getBalance();

            BankA bankB = new BankB();
            bankB.getBalance();

            BankB bankC = new BankC();
            bankC.getBalance();
        }
    }
    public abstract class Bank 
    {
        public abstract void getBalance();
    }
    public class BankA : Bank
    {
      public override void getBalance()
      {
          Console.WriteLine("$" + 100);
      }
    }
     public class BankB : BankA
    {
      public override void getBalance()
      {
          Console.WriteLine("$" + 150);
      }
    }
     public class BankC : BankB
    {
      public override void getBalance()
      {
          Console.WriteLine("$" + 200);
      }
    }
}
