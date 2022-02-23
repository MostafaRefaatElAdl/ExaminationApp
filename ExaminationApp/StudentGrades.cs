using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationApp
{
    internal class StudentGrades
    {
        public string Student_Name { get; set; }
        public string Course_Name { get; set; }
        public int Student_grade { get; set; }

        public string Student_Status {
            get 
            { 
                return $"{Course_Name} \t {Student_grade}%"; 
            } 
        }
           
    }
}
