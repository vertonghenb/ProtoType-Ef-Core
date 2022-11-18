using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable(typeof(T).Name); // All tables are singlular named
        builder.Property(x => x.Id).HasColumnOrder(0);
        builder.Property(x => x.IsEnabled).IsRequired().HasDefaultValue(true).ValueGeneratedNever().HasColumnOrder(1);
        builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()").HasColumnOrder(2);
        builder.Property(x => x.UpdatedAt).HasDefaultValueSql("GETUTCDATE()").IsConcurrencyToken().HasColumnOrder(3);
    }
}


