using AeroIF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroIF.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(u => u.RegisterDate)
                .IsRequired();
            builder.Property(u => u.LoginDate)
                .IsRequired();
            builder.Property(u => u.IsActive)
                .IsRequired();
            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
