using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationApp
{
      class StudentGrades
      {
        public string Student_Name { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_grade { get; set; }

        public string Student_Status {
            get 
            { 
                return $"{Crs_Name} \t {Crs_grade}%"; 
            } 
        }
           
    }
}
