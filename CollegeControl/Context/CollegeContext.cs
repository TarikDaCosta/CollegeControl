using CollegeControl.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CollegeControl.Context
{
    public class CollegeContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Grades> Grades { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}