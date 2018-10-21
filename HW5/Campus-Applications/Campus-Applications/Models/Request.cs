using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Campus_Applications.Models
{
    public class Request
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ApartmentName { get; set; }

        [Required]
        public string Explanation { get; set; }

        [Required]
        public int UnitNumber { get; set; }

        private DateTime date = DateTime.Now;

        public DateTime SignedDate
        {
            get { return date; }
            set { date = value; }
        }
    }
  
}