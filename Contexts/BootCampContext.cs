using BootCam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.BootCam
{
    public class BootCampContext : DbContext


    {
        public BootCampContext(DbContextOptions<BootCampContext> options) : base(options) { }


       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>(eb =>
            {
                eb.HasKey(x => new { x.Id });
            });
        }
        public DbSet<User> User { get; set; }



       

    }


}
