using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options){ }

        public DbSet<Inventory> Items => Set<Inventory>();
        public DbSet<User> Users => Set<User>();
        
        //public DbSet<Exchange> Exchanges => Set<Exchange>();
    }
}