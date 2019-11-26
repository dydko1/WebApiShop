using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiShop.Models
{
    public class WebApiShopContext : DbContext
    {
        public WebApiShopContext (DbContextOptions<WebApiShopContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiShop.Models.Product> Product { get; set; }
    }
}
