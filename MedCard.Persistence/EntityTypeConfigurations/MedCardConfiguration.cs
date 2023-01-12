using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MedCard.Domain;

namespace MedCard.Persistence.EntityTypeConfigurations;

public class MedCardConfiguration : IEntityTypeConfiguration<Domain.MedCard>
{

    public void Configure(EntityTypeBuilder<Domain.MedCard> builder)
    {
        builder.HasKey(note => note.Id);
        builder.HasIndex(note => note.Id).IsUnique();
        builder.Property(note => note.Title).HasMaxLength(250);
    }
    
}