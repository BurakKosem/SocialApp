using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence.Seeding
{
    public class ActivitySeed : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(new Activity
            {
                Id = Guid.NewGuid(),
                Title = "Duman Konseri",
                Category = "Konser",
                Description = "konser",
                City = "İstanbul",
                Date = DateTime.Now,
                Venue = "Maltepe",        
                //Attendees = new List<ActivityAttendee>
                //{
                //    new ActivityAttendee
                //    {
                //        AppUser = ,
                //        IsHost = true,
                //    }
                //}
            });
        }
    }
}
