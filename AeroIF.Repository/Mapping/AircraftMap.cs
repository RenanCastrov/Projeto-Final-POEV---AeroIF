using AeroIF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroIF.Repository.Mapping
{
    public class AircraftMap : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.ToTable("Aircraft");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Model)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(a => a.Company)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Capacity)
                .IsRequired();
        }
    }
}
