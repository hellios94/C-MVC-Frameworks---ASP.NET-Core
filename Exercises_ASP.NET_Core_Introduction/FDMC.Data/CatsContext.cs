using FDMC.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace FDMC.Data
{
    public class CatsContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Database=Cats_MVC;Integrated Security=true");
            }
            base.OnConfiguring(optionsBuilder);
        }


    }
}
