using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    class Marks
    {
        public int RollNo { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public int Mark { get; set; }


       static List<Marks> marks = new List<Marks>()
       {
           new Marks{RollNo=1,Class="1A",Subject="Math",Mark=80},
           new Marks{RollNo=2,Class="1A",Subject="Math",Mark=10},
           new Marks{RollNo=3,Class="1A",Subject="Math",Mark=15},
           new Marks{RollNo=4,Class="1A",Subject="Math",Mark=17},
           new Marks{RollNo=5,Class="1A",Subject="Math",Mark=21},
           new Marks{RollNo=1,Class="1A",Subject="Enq",Mark=80},
           new Marks{RollNo=2,Class="1A",Subject="Enq",Mark=0},
           new Marks{RollNo=3,Class="1A",Subject="Enq",Mark=54},
           new Marks{RollNo=4,Class="1A",Subject="Enq",Mark=38},
           new Marks{RollNo=5,Class="1A",Subject="Enq",Mark=65},
           new Marks{RollNo=1,Class="1A",Subject="Phy",Mark=64},
           new Marks{RollNo=2,Class="1A",Subject="Phy",Mark=45},
           new Marks{RollNo=3,Class="1A",Subject="Phy",Mark=89},
           new Marks{RollNo=4,Class="1A",Subject="Phy",Mark=44},
           new Marks{RollNo=5,Class="1A",Subject="Phy",Mark=49},
           new Marks{RollNo=1,Class="1A",Subject="Chem",Mark=62},
           new Marks{RollNo=2,Class="1A",Subject="Chem",Mark=71},
           new Marks{RollNo=3,Class="1A",Subject="Chem",Mark=90},
           new Marks{RollNo=4,Class="1A",Subject="Chem",Mark=54},
           new Marks{RollNo=5,Class="1A",Subject="Chem",Mark=41},
           new Marks{RollNo=1,Class="1A",Subject="Bio",Mark=54},
           new Marks{RollNo=2,Class="1A",Subject="Bio",Mark=35},
           new Marks{RollNo=3,Class="1A",Subject="Bio",Mark=90},
           new Marks{RollNo=4,Class="1A",Subject="Bio",Mark=91},
           new Marks{RollNo=5,Class="1A",Subject="Bio",Mark=62}

       };

        public List<Marks> GetMark()
        {
            return marks;
        }




    }

   
}
