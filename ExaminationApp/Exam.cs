using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationApp
{
    internal class Exam
    {
        
        public int Q_id { get; set; }    
        public int Exam_id { get; set; }      
        public string Q_desc { get; set; }
        public string Q_choices { get; set; }

        public string[] SplitChoices()
        {
            string[] choicesSplited = Q_choices.Split(',');
            return choicesSplited;
        }

    }
      
}
