using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class MedicalAppointment
    {
        public Patient Patient { get; private set; }
        public DateTime ScheduleStart { get; private set; }
        public DateTime ScheduleEnd { get; private set; }
        public TimeStatus Status { get; set; }

        public MedicalAppointment(Patient patient, DateTime scheduleStart, DateTime scheduleEnd)
        {
            Patient = patient;
            ScheduleStart = scheduleStart;
            ScheduleEnd = scheduleEnd;
            this.Status = TimeStatus.Scheduled;
        }

        public override string ToString()
        {
            return "Appointment with " + this.Patient + " (" + this.ScheduleStart + " - " + this.ScheduleEnd + ")" + "\nStatus: " + this.Status;
        }
    }
}
