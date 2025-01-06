using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_manager_models
{
    public class CashRegister
    {
        public int RegisterId { get; set; }
        public Person CurrentCustomer { get; set; }

        public CashRegister(int registerId)
        {
            RegisterId = registerId;
            CurrentCustomer = null;
        }

        // פונקציה שמטפלת בלקוח בקופה צריך לבדוק איך לממש את זה טוב!!
        public void ProcessCustomer()
        {
            if (CurrentCustomer != null)
            {
                Console.WriteLine($"Processing customer {CurrentCustomer.ToString()} at register {RegisterId}");
                CurrentCustomer = null;
            }
        }

        public bool IsAvailable()
        {
            return CurrentCustomer == null;
        }
    }

}
