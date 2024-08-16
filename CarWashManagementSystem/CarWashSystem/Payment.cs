using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSystem
{
    abstract class Payment
    { 
        public int PaymentId { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public string PaymentMethod { get; set; }

        public abstract void processPayment();
    }
}
