using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management
{
    public class PatientRecord
    {
        public Patient Patient { get; private set; }
        public TransactionType Transaction { get; private set; }
        public int RoomNumber { get; private set; }
        public List<Staff> AdministeringStaff { get; private set; }
        public ConditionStatus Status { get; set; }
        public string Remarks { get; private set; }

        public PatientRecord(Patient patient, TransactionType transaction, int roomNumber, ConditionStatus status)
        {
            this.Patient = patient;
            this.Transaction = transaction;
            this.RoomNumber = roomNumber;
            this.AdministeringStaff = new List<Staff>();
            this.Status = status;
            this.Remarks = string.Empty;
        }

        public override string ToString()
        {
            string s = "__________________\n" +
                "Patient Name: " + this.Patient;
            if (this.Transaction == TransactionType.Admission)
                s += " admitted to Room " + this.RoomNumber;
            s += ". Currently " + this.Status + "\n\t Administered by:\n";

            foreach(var e in this.AdministeringStaff)
            {
                s += e + "\n";
            }

            s += "Remarks: " + this.Remarks + "\n__________________";

            return s;
        }
    }
}
