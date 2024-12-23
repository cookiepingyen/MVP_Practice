using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習.Models.ViewModel
{
    internal class EmpOverTimeGraph
    {
        public int Emp_id { get; set; }
        public double overHours { get; set; }
        public string Reason { get; set; }
    }
}
