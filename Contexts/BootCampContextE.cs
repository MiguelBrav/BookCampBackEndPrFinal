using BootCam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.BootCam
{
    public class BootCampContextE : DbContext
    {
        public BootCampContextE(DbContextOptions<BootCampContextE> options) : base(options) { }


       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Enterprise>(eb =>
            {
                eb.HasKey(x => new { x.Id });
            });
        }
        public DbSet<Enterprise> Enterprise { get; set; }



       

    }
}
