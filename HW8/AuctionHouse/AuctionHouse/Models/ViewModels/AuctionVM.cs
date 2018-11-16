using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionHouse.Models.ViewModels
{
    public class AuctionVM
    {
        public Item VmItem { get; set; }

        public List<Bid> VMBid { get; set; }
    }
}