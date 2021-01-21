using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory.Class
{
    public class MyContext : DbContext
    {
        public DbSet<TelePhoneDirectory> userDirectory { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=maximdb;Username=maxim;Password=$544$B77w**G)K$t!Ube22}rad");
        }
    }
}
