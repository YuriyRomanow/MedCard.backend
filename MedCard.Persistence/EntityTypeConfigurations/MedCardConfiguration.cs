using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedCard.Persistence.EntityTypeConfigurations;

public class MedCardConfiguration : IEntityTypeConfiguration<Domain.MedCard.MedCard>
{

    public void Configure(EntityTypeBuilder<Domain.MedCard.MedCard> builder)
    {
        builder.HasKey(note => note.Id);
        builder.HasIndex(note => note.Id).IsUnique();
        builder.Property(note => note.Title).HasMaxLength(250);
    }
    
}