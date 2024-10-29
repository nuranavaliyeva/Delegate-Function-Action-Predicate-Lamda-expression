using System.Threading.Channels;
using Tapsiriq2.Models;

namespace Tapsiriq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>
            {
                new Exam("Math", 3, DateTime.Parse("2024 10 29 09:00") ),
                new Exam("pys", 2, DateTime.Parse("2024 4 29 09:00") ),
                new Exam("mad", 5, DateTime.Parse("2024 10 29 23:00") )

            };
            List<Exam> searched1 = exams.FindAll(e => e.ExamDuration > 2);
            List<Exam> searched2 = (exams.FindAll(e => e.StartDate >= DateTime.Now.AddDays(-7)));
            List<Exam> searched3 = (exams.FindAll(e => e.StartDate<=DateTime.Now && e.EndDate>=DateTime.Now));
            searched3.ForEach(e => Console.WriteLine($"Subject:{e.Subject}, Exam Duration: {e.ExamDuration}"));

        }
    }
}
