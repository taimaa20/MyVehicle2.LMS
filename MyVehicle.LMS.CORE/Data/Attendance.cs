using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public DateTime AtStartDate { get; set; }
        public DateTime AtEndDate { get; set; }
        public bool AtStatus { get; set; }
        public int UserId { get; set; }
    }
}
