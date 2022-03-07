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
        public int Math { get; set; }
        public int Enq { get; set; }
        public int Phy { get; set; }
        public int Chem { get; set; }
        public int Bio { get; set; }

        List<Marks> marks = new List<Marks>()
       {
           new Marks{RollNo=1,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=2,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=3,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=4,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=5,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=6,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=7,Math=62,Enq=76,Phy=65,Chem=76,Bio=81},
           new Marks{RollNo=8,Math=62,Enq=76,Phy=65,Chem=76,Bio=81}


       };




    }

   
}
