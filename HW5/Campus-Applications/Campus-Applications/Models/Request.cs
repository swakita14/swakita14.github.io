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
        /// <summary>
        /// Key 
        /// </summary>
        public int ID { get; set; }

        //Data Attributtes
        /// <summary>
        /// First name of the tenant 
        /// </summary>
        [Required(ErrorMessage = "First Name is Required")]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the tenant
        /// </summary>
        [Required(ErrorMessage = "Last Name is Required")]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }

        /// <summary>
        /// Phone number of the person requesting help
        /// </summary>
        [Required(ErrorMessage = "Phone Number is Required")]
        [DisplayName("Phone Number:")]
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$", ErrorMessage = "Please use the format: XXX-XXX-XXXX")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// user or the tenants apartment name
        /// </summary>
        [Required(ErrorMessage = "Apartment Name is Required")]
        [DisplayName("Apartment Name:")]
        public string ApartmentName { get; set; }

        /// <summary>
        /// This is the description of the problem
        /// </summary>
        [Required(ErrorMessage = "A Description is Required")]
        [DisplayName("Problem Description:")]
        public string Explanation { get; set; }

        /// <summary>
        /// This is the unit number of the aparment
        /// </summary>
        [Required(ErrorMessage = "Unit Number is Required")]
        [DisplayName("Unit Number:")]
        public int UnitNumber { get; set; }

        /// <summary>
        /// This is the checkbox that is selected if the users give permission to the owners to enter
        /// </summary>
        [DisplayName("Permission to enter unit to perform request:")]
        public bool CallMe { get; set; }

        /// <summary>
        /// Stamps the form with the current date and time
        /// </summary>
        private DateTime date = DateTime.Now;
        [DisplayName("Submittion Date:")]
        public DateTime SignedDate
        {
            get { return date; }
            set { date = value; }
        }
    }
  
}