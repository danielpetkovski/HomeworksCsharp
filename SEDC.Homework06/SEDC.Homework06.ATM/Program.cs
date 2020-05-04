using SEDC.Homework06.Entities;
using SEDC.Homework06.Entities.Services;
using System;

namespace SEDC.Homework06.ATM
{
    class Program
    {
        static void Main(string[] args)
        {



            Customer[] customers = GenerateCustomers();
            var validationService = new ValidationService();
            while (true)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1.Register new card \n2.Login");
                string userFirstOptionString = Console.ReadLine();
                if (!int.TryParse(userFirstOptionString, out int validUserOption))
                {
                    Console.WriteLine("Not valid input. Please try again.");
                    continue;
                }
                switch(validUserOption)
                {
                    case 1:
                        Console.WriteLine("Please insert your First name:");
                        string newFirstName = Console.ReadLine();

                        Console.WriteLine("Please insert your Last name:");
                        string newLastName = Console.ReadLine();

                        Console.WriteLine("Please insert your new Card number");
                        string newCardNumberString = Console.ReadLine();
                        string[] c1 = new string[] { "-" };
                        foreach (var item in c1)
                        {
                            newCardNumberString = newCardNumberString.Replace(item, string.Empty);
                        }
                        string trimmedCardNumber = newCardNumberString.Trim();
                        if (!(trimmedCardNumber.Length == 16))
                        {
                            Console.WriteLine("Enter valid card number");
                            continue;
                        }
                        
                        long newCardNumber;
                        if (!long.TryParse(trimmedCardNumber, out newCardNumber))
                        {
                            Console.WriteLine("Enter valid card number");
                            continue;
                        }

                        foreach (Customer item in customers)
                        {
                            if (item.CardNumber == newCardNumber)
                            {
                                Console.WriteLine("We already have a customer by that card number");
                                continue;
                            }
                        }
                        Console.WriteLine("Insert your new pin number");
                        string newPinString = Console.ReadLine();
                        if(!(newPinString.Length == 4))
                        {
                            Console.WriteLine("Insert valid pin number");
                            continue;                       
                        }
                        int newPin;
                        if(!int.TryParse(newPinString, out newPin))
                        {
                            Console.WriteLine("Insert valid pin number");
                            continue;
                        }

                        Array.Resize(ref customers, customers.Length + 1);
                        Customer newCustomer = new Customer(newFirstName, newLastName, newCardNumber, newPin);
                        customers[customers.Length - 1] = newCustomer;
                        Console.WriteLine($"Welcome {newCustomer.FirstName} {newCustomer.LastName}. You have successfully joined our ATM!");

                        break;
                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Customer customer = Authentication.Login(customers, validationService);
                            while (true)
                            {
                                Console.Clear();
                                customer.PrintInfo();
                                Console.WriteLine("\n1.Balance checking \n2.Cash Withdrawal \n3.Cash Deposition");
                                string userSelection = Console.ReadLine();

                                if (!int.TryParse(userSelection, out int validUserSelection))
                                {
                                    Console.WriteLine("Not valid input. Please try again.");
                                    continue;
                                }

                                switch (validUserSelection)
                                {
                                    case 1:

                                        customer.BalanceChecking();
                                        break;
                                    case 2:
                                        Console.WriteLine("Please input ammount for withdrawal:");
                                        string userInputMoney = Console.ReadLine();
                                        int validUserInput;
                                        int.TryParse(userInputMoney, out validUserInput);
                                        customer.CashWithdrawal(validUserInput);
                                        break;
                                    case 3:
                                        Console.WriteLine("Please input ammount for deposition:");
                                        string userInputMoney2 = Console.ReadLine();
                                        int validUserInput2;
                                        int.TryParse(userInputMoney2, out validUserInput2);
                                        customer.CashDeposit(validUserInput2);
                                        break;
                                }
                                Console.WriteLine("Would you like to do another action? y/n");
                                string actionInput = Console.ReadLine();
                                if (actionInput == "n")
                                {
                                    break;
                                }
                            }




                        }
                }
            }


        }

        static Customer[] GenerateCustomers()
        {
            return new Customer[]
            {
        new Customer("Daniel", "Petkovski", 1111222233334444,1224),
        new Customer("Marija", "Marievska", 2222111133334444, 1285),
        new Customer("Goce", "Delcev", 7777888899995555, 9988),

            };
        }

    }


  
}
