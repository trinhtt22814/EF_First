using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BAI_4_EFCore_CodeFirst.A_DAL.Models
{
    internal class DogManagerContext : DbContext
    {
        public DbSet<Human> Humans { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DogManagerContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FC26M26\SQLEXPRESS;Database=QuanLyCho;Trusted_Connection=True;");
        }




    }
}
