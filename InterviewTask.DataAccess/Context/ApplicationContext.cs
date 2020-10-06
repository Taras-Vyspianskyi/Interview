using InterviewTask.Common.Entity;
using InterviewTask.DataAccess.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.DataAccess.Context
{
    public class ApplicationContext : DbContext
    {
        #region Constructors        
        
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        #endregion

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new PersonConfig());
        }
    }
}
