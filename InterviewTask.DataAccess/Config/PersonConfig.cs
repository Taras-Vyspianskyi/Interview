using InterviewTask.Common.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.DataAccess.Config
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasIndex(b => b.Id);

            builder.HasAlternateKey(b => b.Email);

            builder.Property(b => b.FirstName)
                .IsRequired();

            builder.Property(b => b.LastName)
                .IsRequired();

            builder.Property(b => b.Address)
                .IsRequired();

            builder.Property(b => b.PhoneNumber)
                .IsRequired();

            builder.Property(b => b.FaceBookLink);

            builder.Property(b => b.TwitterLink);
        }
    }
}
