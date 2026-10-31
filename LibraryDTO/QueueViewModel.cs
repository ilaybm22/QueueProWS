using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class QueueViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        public string ServiceName { get; set; }

        [Required(ErrorMessage = "שדה חובה")]
        public string BusinessName { get; set; }

        [Required(ErrorMessage = "יש לבחור תאריך ושעה")]
        public DateTime AppointmentDate { get; set; }
    }

}
