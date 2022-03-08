using System;
using System.Collections.Generic;
using System.Linq;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Marks mark = new Marks();
            
            List<Student> students = new List<Student>();
            List<Marks> marks = mark.GetMark();


            var TotalMarkResult = from m in marks
                                  group m by m.RollNo into TotalMarks
                                  select new
                                  {
                                      RollNumber = TotalMarks.Key,
                                      TotalMark = TotalMarks.Sum(x => x.Mark),
                                      TotalSubject = TotalMarks.Count(),
                                      Average = TotalMarks.Sum(x => x.Mark) / TotalMarks.Count(),
                                      Percentage = TotalMarks.Sum(x => x.Mark) / TotalMarks.Count(),
                                      Grade = TotalMarks.Sum(x => x.Mark) / TotalMarks.Count() >= 60 ? "A" :
                                              TotalMarks.Sum(x => x.Mark) / TotalMarks.Count() >= 50 ?"B" :
                                              TotalMarks.Sum(x => x.Mark) / TotalMarks.Count() >= 35 ? "C" :
                                             "Failed"
                                 
                             };

            var results = marks.GroupBy(
            p => p.RollNo,
           (key, g) => new { RollNo = key, TotalMarks = g.Sum(m=>m.Mark),TotalSubject=g.Count() });

            foreach (var item in TotalMarkResult)
            {
                Console.WriteLine(item);
            }


            var query = students.Join(
                TotalMarkResult,
                stud => stud.RollNo,
                tm => tm.RollNumber,
                (stud, tm) => new
                {
                    RollNumber = stud.RollNo,
                    Average = tm.Average,
                    Percentage = tm.Percentage,
                    Grade=tm.Grade
                   
                });

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
    }
}
