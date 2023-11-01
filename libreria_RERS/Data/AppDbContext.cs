﻿using libreria_RERS.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace libreria_RERS.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
            
        {

        }

        public DbSet<Books> Books { get; set; } 
    }
}
