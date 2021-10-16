using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class Permissions
    {
        [Key]
        public int PermissionsId { get; set; }
        public int RoleId { get; set; }
    }
}
