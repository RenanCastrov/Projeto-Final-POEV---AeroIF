using AeroIF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroIF.Repository.Mapping
{
    public class AirportMap : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.ToTable("Airport");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(a => a.Code)
                .IsRequired()
                .HasMaxLength(10);
            builder.HasOne(a => a.City)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
