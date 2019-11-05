using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Fist.Aplication.MVC.Models
{
    public class FistAplicationMVCContext : DbContext
    {
        public FistAplicationMVCContext (DbContextOptions<FistAplicationMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Fist.Aplication.MVC.Models.Departament> Departament { get; set; }
    }
}
