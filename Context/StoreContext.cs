using mvc5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc5.Context
{
    public class StoreContext: DbContext
    {
        public DbSet<product> products { get; set; }


    }
}