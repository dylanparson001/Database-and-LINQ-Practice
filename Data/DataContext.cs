using Microsoft.EntityFrameworkCore;
using Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Data
{
    internal class DataContext : DbContext
    {
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source=PARS-LAPTOP\\SQLEXPRESS;Initial Catalog=AppointmentTrackerConsole;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
