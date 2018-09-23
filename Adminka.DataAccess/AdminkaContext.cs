using Adminka.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adminka.DataAccess
{
    public class AdminkaContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public AdminkaContext()
            : base("DefaultConnection")
        { }
    }

}
