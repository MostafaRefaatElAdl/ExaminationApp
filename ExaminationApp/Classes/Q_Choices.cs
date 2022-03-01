using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationApp
{
    public class Q_Choices
    {
        public string Q_choices { get; set; }

        public string[] SplitChoices(Q_Choices choices)
        {
            string[] answer = choices.ToString().Split(',');
            return answer;

        }
        public override string ToString()
        {
            return $"{Q_choices}";
        }
    }
}
