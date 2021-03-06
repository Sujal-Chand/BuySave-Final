using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuySave_Final.Models;

    public class BuySave_FinalContextdb : DbContext
    {
        public BuySave_FinalContextdb (DbContextOptions<BuySave_FinalContextdb> options)
            : base(options)
        {
        }

        public DbSet<BuySave_Final.Models.Catagory> Catagory { get; set; }

        public DbSet<BuySave_Final.Models.Country> Country { get; set; }

        public DbSet<BuySave_Final.Models.Product> Product { get; set; }

        public DbSet<BuySave_Final.Models.Review> Review { get; set; }

        public DbSet<BuySave_Final.Models.User> User { get; set; }
    }
