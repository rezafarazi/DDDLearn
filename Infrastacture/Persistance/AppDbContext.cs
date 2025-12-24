using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastacture.Persistance
{
    public class AppDbContext
    {

        public DbSet<tbl_users> Users { get; set; }

    }
}
