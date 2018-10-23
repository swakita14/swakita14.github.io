using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$", ErrorMessage = "Please use the format: XXX-XXX-XXXX")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Apartment Name")]
        public string ApartmentName { get; set; }

        [Required]
        [DisplayName("Problem Description")]
        public string Explanation { get; set; }

        [Required]
        [DisplayName("Unit Number")]
        public int UnitNumber { get; set; }

        [DisplayName("Permission to enter unit to perform request")]
        public bool CallMe { get; set; }

        private DateTime date = DateTime.Now;
        [DisplayName("Submittion Date")]
        public DateTime SignedDate
        {
            get { return date; }
            set { date = value; }
        }
    }
  
}