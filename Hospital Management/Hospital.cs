using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class Hospital
    {
        public List<StaffRecord> EmployeeRecords { get; private set; }
        public List<PatientRecord> PatientRecords { get; private set; }
        public List<MedicalAppointment> Appointments { get; private set; }

        public Hospital()
        {
            this.EmployeeRecords = new List<StaffRecord>();
            this.PatientRecords = new List<PatientRecord>();
            this.Appointments = new List<MedicalAppointment>();
        }

        public void Hire(Staff employee, string jobTitle, string department, double salary, DateTime startShift, DateTime endShift)
        {
            foreach (var e in this.EmployeeRecords)
            {
                if (e.Employee == employee) return;
            }

            StaffRecord newStaff = new StaffRecord(employee, jobTitle, department, salary, startShift, endShift);
            this.EmployeeRecords.Add(newStaff);
        }

        public void Fire(Staff employee)
        {
            foreach (var e in this.EmployeeRecords)
            {
                if (e.Employee == employee)
                {
                    this.EmployeeRecords.Remove(e); return;
                }
            }
        }

        public override string ToString()
        {
            string s = "This hospital has the following:\n";
            s += "STAFF:\n";
            foreach(var e in this.EmployeeRecords) { s += e + "\n"; }
            s += "\nPATIENTS: \n";
            foreach(var p in this.PatientRecords) { s += p + "\n"; }
            s += "\nAPPOINTMENTS: \n";
            foreach(var a in this.Appointments) { s += a + "\n"; }
            return s;
        }
    }
}
