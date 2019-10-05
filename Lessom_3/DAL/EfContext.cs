using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EfContext : DbContext
    {
        public EfContext(): base ("myCon")
        {

        }
        public DbSet<Img> imgs { get; set; }
    }
}
