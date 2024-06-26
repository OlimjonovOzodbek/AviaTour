﻿using AviaTour.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AviaTour.Infrastructure.Configurations
{
    public class TourConfigurations : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.Property(x => x.Where)
                .HasMaxLength(80);

            builder.Property(x => x.WhereEx)
                .HasMaxLength(80);

            builder.Property(x => x.Subtitle)
                .HasMaxLength(170);

            builder.Property(x => x.DeletedAt)
                .HasColumnType("text");


            builder.HasQueryFilter(x => x.IsDeleted == false);
        }
    }
}
