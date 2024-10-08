﻿using Microsoft.EntityFrameworkCore;
using WindowSystems.DL.DO;

namespace WindowSystems.DataAccess
{
    public class WeatherDbContext : DbContext
    {
        public DbSet<Weather> Weathers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");

        }
    }

}
