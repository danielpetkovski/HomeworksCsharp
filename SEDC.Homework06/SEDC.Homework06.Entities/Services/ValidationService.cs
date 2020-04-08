using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework06.Entities.Services
{
   public class ValidationService
    {
        public bool ValidateCard(long card, Customer[] customers)
        {
            foreach (var customer in customers)
            {
                if (customer.CardNumber == card)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidatePin(int pin, Customer[] customers)
        {
            foreach (var customer in customers)
            {
                if (customer.Pin == pin)
                {
                    return true;
                }

            }
            return false;
        }
        


    }
}
