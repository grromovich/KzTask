﻿using Microsoft.EntityFrameworkCore;

namespace KZtask.Models
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"workstation id=TasksDB.mssql.somee.com;packet size=4096;user id=samuelmoore_SQLLogin_1;
                                                pwd=qv4m4l8qse;data source=TasksDB.mssql.somee.com;persist security info=False;
                                                initial catalog=TasksDB;TrustServerCertificate=True";

        private const string localDB = @"Server=localhost;Database=my_db;Trusted_Connection=True;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tasks { get; set; }
    }
}
