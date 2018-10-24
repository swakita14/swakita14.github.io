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

        public RequestdbContext() : base("name=Requests")
        {

        }

        public virtual DbSet<Request> Requests { get; set; }
    }
}