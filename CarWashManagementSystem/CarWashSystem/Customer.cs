using System;

namespace CarWashSystem
{
    public class Customer
    {
        // Properties
        public string CustomerID { get; set; }
        public string Nic { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public string ServiceHistory { get; set; }

        // Constructor
        public Customer(string customerID, string nic, string name, string contactInfo, string email, string serviceHistory)
        {
            Nic = nic;
            Name = name;
            ContactInfo = contactInfo;
            Email = email;
            ServiceHistory = serviceHistory;
        }
    }
}
