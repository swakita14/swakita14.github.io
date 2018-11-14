using AuctionHouse.Models;
using AuctionHouse.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionHouse.Controllers
{
    public class BidApiController : Controller
    {
        private AuctionContext db = new AuctionContext();
        public JsonResult ItemBids(int? id)
        {

            AuctionVM vm = new AuctionVM();

            //Find the Item with the id
            vm.VmItem = db.Items.Find(id);

            //Item ID that has a bid
            int pid = vm.VmItem.Bids.FirstOrDefault().ItemID;


            //Assign it to the bid
            vm.VMBid = db.Items.SelectMany(x => x.Bids)
                                .Where(i => i.ItemID == pid)
                                .OrderBy(t => t.TimeStamp)
                                .ToList();
            
                                    
            //Serialize the JSON data
            string jsonItem = JsonConvert.SerializeObject(vm.VMBid);

            Debug.WriteLine(vm.VMBid.Count);






            //Send it back
            return Json(jsonItem , JsonRequestBehavior.AllowGet);
        }
    }
}