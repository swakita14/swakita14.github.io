using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AJAX_WebApp.Models
{
    public class LogEvent
    {
        /// <summary>
        /// Key 
        /// </summary>
        public int ID { get; set; }

        public DateTime AccessTime { get; set; }

        [Required]
        public string Request { get; set; }

        [Required]
        public string IPAddress { get; set; }

        [Required]
        public string ClientBrowser { get; set; }




       
    }
}
