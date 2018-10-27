using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Campus_Applications.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Campus_Applications.DAL
{
    public class RequestdbContext : DbContext
    {
        /// <summary>
        /// This is the context constructor that bridges the db with the application
        /// </summary>
        public RequestdbContext() : base("name=Requests")
        {

        }

        /// <summary>
        /// Tells you what you can do with the db whether to get information from it or set information in it. 
        /// </summary>
        public virtual DbSet<Request> Requests { get; set; }
    }
}