namespace AuctionHouse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bid")]
    public partial class Bid
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        [Required]
        [StringLength(30)]
        public string Buyer { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number")]
        public int Price { get; set; }

        private DateTime date = DateTime.Now;

        public DateTime TimeStamp
        {
            get { return date; }
            set { date = value; }
        }

        public virtual Item Item { get; set; }

        public virtual Buyer Buyer1 { get; set; }
    }
}
