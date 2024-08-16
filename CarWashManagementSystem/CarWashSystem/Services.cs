using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSystem
{
    abstract class Services
    {
        // Getters and Setters
        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public TimeOnly Duration { get; set; }

        public void updateService(Services service, int serviceID) { }
        public bool RemoveService(int serviceId) 
        { 
            return false; 
        }
        public abstract void performService();
    }
}
