using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class Appointment
    {
        public string AppointmentID {  get; set; }
        public int UserID { get; set; }
        public int ServiceID { get; set; }
        public string StartTime { get; set; }
        public string Status { get; set; }

    }
}
