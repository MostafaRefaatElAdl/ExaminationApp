using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationApp
{
    internal class Student
    {
        public int St_id { get; set; }
        public string StF_Name { get; set; }
        public string StL_Name { get; set; } 
        public string St_Address { get; set; }
        public int St_Age { get; set; }
        public string St_Password { get; set; }
        public int St_National_id { get; set; }

        public int Dept_id { get; set; }

        public string Dept_name { get; set; }

        public override string ToString()
        {
            return $"{StF_Name} {StL_Name} ";
        }
    }
}
