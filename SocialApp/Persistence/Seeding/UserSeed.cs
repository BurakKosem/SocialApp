using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Seeding
{
    public class UserSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {

            var test = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Test",
                Email = "test@gmail.com",
                NormalizedEmail = "TEST@GMAIL.COM",
                NormalizedUserName = "TEST",
                DisplayName = "Test",
            };
            test.PasswordHash = CreatePasswordHash(test, "Test123!");
            builder.HasData(test);


        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
