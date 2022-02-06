﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Character> Characters { get; set; }

    }
}
