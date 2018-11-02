using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldWideImporter.Models.CompanyViewModel
{
    public class ViewModel
    {
        /// <summary>
        /// Thie is the person object and allows it to be assigned the person from the db
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Thie is the customer object and allows it to be assigned the customer from the db
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Thie is the List of Invoice Lines and allows it to be assigned the Invoice Lines from the db
        /// </summary>
        public List<InvoiceLine> InvoiceLine { get; set; }

       

    }
}