using AJAX_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AJAX_WebApp.DAL
{

    public class LogDbContext : DbContext
    {


        public LogDbContext() : base("name=Log_Entry")
        {

        }

        /// <summary>
        /// Tells you what you can do with the db whether to get information from it or set information in it. 
        /// </summary>
        public virtual DbSet<LogEvent> Logs { get; set; }

    }
}