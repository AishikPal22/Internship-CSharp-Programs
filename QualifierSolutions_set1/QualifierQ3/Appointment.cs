using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualifierQ3
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Reason { get; set; }
    }
    
    public Appointment() { }
    
    public Appointment(string name, string date, string time, string reason)
    {
        PatientName = name; 
        Date = date;
        Time = time; 
        Reason = reason;
    }
}
