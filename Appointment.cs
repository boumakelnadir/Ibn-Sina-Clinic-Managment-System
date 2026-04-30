using System;

namespace Ibn_Sina_Clinic_Managment_System
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public string ServiceName { get; set; }
        public double Price { get; set; }
        public DateTime AppointmentDateTime { get; set; }
    }
}