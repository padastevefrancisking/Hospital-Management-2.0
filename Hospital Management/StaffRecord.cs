using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class StaffRecord
    {
        public Staff Employee { get; private set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime StartShift { get; private set; }
        public DateTime EndShift { get; private set; }

        public StaffRecord(Staff employee, string jobTitle, string department, double salary, DateTime startShift, DateTime endShift)
        {
            this.Employee = employee;
            this.JobTitle = jobTitle;
            this.Department = department;
            this.Salary = salary;
            this.StartShift = startShift;
            this.EndShift = endShift;
        }

        public override string ToString()
        {
            return this.Employee + ", " + this.JobTitle + " in " + this.Department + " Department";
        }
    }
}
