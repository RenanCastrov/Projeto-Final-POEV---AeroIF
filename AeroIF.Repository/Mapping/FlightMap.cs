using AeroIF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroIF.Repository.Mapping
{
    public class FlightMap : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("Flight");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.DepartTime)
                .IsRequired();
            builder.Property(f => f.Status)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasOne(f => f.Aircraft)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(f => f.OriginAirport)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(f => f.DestinyAirport)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(f => f.Pilot)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
