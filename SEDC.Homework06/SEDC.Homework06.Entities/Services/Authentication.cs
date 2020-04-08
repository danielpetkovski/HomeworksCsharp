using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework06.Entities.Services
{
    public static class Authentication
    {
        public static Customer Login(Customer[] customers, ValidationService validationService)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the ATM app!");
                Console.WriteLine($"Please enter your card number: ####-####-####-####");
                string cardNumberInput = Console.ReadLine();
                string[] c1 = new string[] { "-" };
                foreach (var item in c1)
                {
                    cardNumberInput = cardNumberInput.Replace(item, string.Empty);
                }

                string trimmedSelection = cardNumberInput.Trim();
                long cardNumber;
                if (!long.TryParse(trimmedSelection, out cardNumber))
                {
                    Console.WriteLine("Enter valid input");
                    continue;
                }

                if (!validationService.ValidateCard(cardNumber, customers))
                {
                    Console.WriteLine("No user with such card number");
                    continue;
                }

                Customer customer = FindCustomer(cardNumber, customers);
                Console.WriteLine("Please enter your pin number:");
                string inputPinString = Console.ReadLine();
                int inputPin;
                if (!int.TryParse(inputPinString, out inputPin)) 
                {
                    Console.WriteLine("Enter valid type input");
                    continue;
                }

                if (!validationService.ValidatePin(inputPin, customers))
                {
                    Console.WriteLine("Enter valid pin number");
                    continue;
                }
                
                return customer;

            }
        }

        private static Customer FindCustomer(long cardNumber, Customer[] customers)
        {
            foreach (var customer in customers)
            {
                if (customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
