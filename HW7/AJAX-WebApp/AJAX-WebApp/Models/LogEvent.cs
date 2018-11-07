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

        /// <summary>
        /// The time that the user input the string and the time that is loggd 
        /// </summary>
        public DateTime AccessTime { get; set; }

        /// <summary>
        /// the string that is input by the user to match the gif
        /// </summary>
        public string Request { get; set; }

        /// <summary>
        /// IP address of the user
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// browser of  client 
        /// </summary>
        public string ClientBrowser { get; set; }




       
    }
}
