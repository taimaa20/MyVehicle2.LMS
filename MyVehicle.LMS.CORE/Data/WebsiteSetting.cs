using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class WebsiteSetting
    {
        [Key]
        public int SettingId { get; set; }
        public string WebName { get; set; }
        public string WebLogo { get; set; }
        public string WebBackground { get; set; }
    }
}
