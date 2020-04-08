using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework06.Entities
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        protected internal int Pin { get; set; }
        protected int Balance { get; set; }


        public Customer(string firstName, string lastName, long cardNumber, int pin)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = 0;
        }



        public void PrintInfo()
        {
            Console.WriteLine($"Welcome {FirstName} {LastName}");
        }

        public void BalanceChecking()
        {
            Console.WriteLine($"Your current balance is: {Balance}");
        }

        public void CashWithdrawal(int input)
        {

            if (Balance < input)
            {
                Console.WriteLine("You do not have enough money on your balance");
            }
            else
            {
                Balance -= input;
                Console.WriteLine($"You have withdrawn {input}, and your current balance is {Balance}");
            }
        }

        public void CashDeposit(int input)
        {
            Balance += input;
            Console.WriteLine($"You have deposited {input}, and your current balance is {Balance}");

        }


    }
}
