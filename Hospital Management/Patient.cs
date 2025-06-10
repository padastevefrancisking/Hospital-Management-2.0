using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Patient : Person
    {
        public Patient(string name, int age, double weight, string address, string phoneNumber) : base(name, age, weight, address, phoneNumber)
        { }

        //hellowwwwwwww
        public void Admit(Hospital hospital, int roomNumber, ConditionStatus status)
        {
            foreach (var p in hospital.PatientRecords)
            {
                if (p.Patient == this) return;
            }

            PatientRecord newPatient = new PatientRecord(this, TransactionType.Admission, roomNumber, status);
            hospital.PatientRecords.Add(newPatient);
        }

        public void MakeAppointment(Hospital hospital, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            MedicalAppointment appointment = new MedicalAppointment(this, dateTimeStart, dateTimeEnd);
            hospital.Appointments.Add(appointment);

            PatientRecord record = new PatientRecord(this, TransactionType.Appointment, 0, 0);
            hospital.PatientRecords.Add(record);
        }

        public void CancelAppointment(Hospital hospital, DateTime dateTimeStart)
        {
            foreach (var a in hospital.Appointments)
            {
                if (a.Patient == this && a.ScheduleStart == dateTimeStart)
                {
                    a.Status = TimeStatus.Cancelled; return;
                }
            }
        }

        public override string ToString()
        {
            return this.Name + " (" + this.Age + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Patient)) return false;

            var p = obj as Patient;
            return ((p.Name == this.Name) && 
                (p.Address == this.Address) && 
                (p.Age == this.Age) && 
                (p.PhoneNumber == this.PhoneNumber) && 
                (p.Weight == this.Weight));
        }
    }
}
