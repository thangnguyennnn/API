using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Data
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStoreDB"));
        }

        public virtual DbSet<Document>? Documents { get; set; }
        public virtual DbSet<Quiz>? Quizes { get; set; }
        public virtual DbSet<Subject>? Subjects { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<UserInformation>? UserInformations { get; set; }
        public virtual DbSet<UserLearning>? UserLearnings { get; set; }

    }
}
