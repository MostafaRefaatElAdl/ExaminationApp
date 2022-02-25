using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationApp
{
    internal class Questions
    {
        public string Q_desc { get; set; }

        public override string ToString()
        {
            return $"{Q_desc}";
        }
    }
}
