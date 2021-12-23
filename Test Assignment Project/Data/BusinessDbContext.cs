using DotNetCoreApiStarter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.Entities;

namespace DotNetCoreApiStarter.Data
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<SearchResult> SearchResults { get; set; }
    }
}
