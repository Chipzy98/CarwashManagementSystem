using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSystem
{
    internal class Employee
    {
        // Getters and Setters
        public int EmployeeId { get; set; }

        public string EName { get; set; }

        public string Role { get; set; }

        public string ContactInfo { get; set; }

        public void addCustomer(Customer customer) { }
        public void addService(Services service) { }

        // Method to get all payments
        public ICollection<Payment> GetAllPayments()
        {
            return new List<Payment>();
        }
    }
}
