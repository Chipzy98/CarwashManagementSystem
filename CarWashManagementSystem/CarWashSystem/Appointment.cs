using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSystem
{
    internal class Appointment
    {
    
        // Getters and Setters
        public int AppointmentId { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string ServiceType { get; set; }

        public bool Status { get; set; }

        public ICollection<Services> Services { get; set; }

        public void bookAppointment() { }
        public void schedule(String nic, int appointmentId) { }
        public void cancel(String nic) { }
        public void addToServiceList(Services services) { }
        public void removeFromServiceList(int serviceId) { }

        // Method to get all appointments
        public ICollection<Appointment> GetAllAppointments()
        {
            return new List<Appointment>();
        }

        // Optional: Method to add an appointment
        public void AddAppointment(Appointment appointment){}
        public void reschedule(DateTime AppointmentDateTime, String nic) { }

    }
}
