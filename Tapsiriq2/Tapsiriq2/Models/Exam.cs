using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriq2.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        
        public Exam(string subject, int duration, DateTime starDate)
        {
            Subject = subject;
            ExamDuration = duration;
            StartDate = starDate;
            EndDate = starDate.AddHours(duration);
        }

    }
    
 
}
