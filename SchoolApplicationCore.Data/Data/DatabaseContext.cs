using Microsoft.EntityFrameworkCore;
using ShoolApplicationCore.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplicationCore.Data.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {}

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Person>().HasData(
                new Person
                {
                     Name = "Ejechi Charles",
                     BirthDate = new DateTime(1982, 11,07),
                     Class = "SS III"
                },
                new Person
                {
                     Name = "Emmanuel Okokon",
                     BirthDate = new DateTime(2011, 06,17),
                     Class = "SS II"
                }
                );
        }
    }
}
