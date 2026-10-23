using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class WorkingHour
    {
        public String HoursID {  get; set; }
        public int BusinessID { get; set; }
        public String DayOfTheWeek { get; set; }
        public String Start { get; set; }
        public String End { get; set; }


    }
}
