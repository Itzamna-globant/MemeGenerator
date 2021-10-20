using MemeGen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetTopologySuite.Geometries;

namespace MemeGen.Infrastructure.Persistence.Configurations
{
    public class MemeTemplateConfiguration: IEntityTypeConfiguration<MemeTemplate>
    {
        public void Configure(EntityTypeBuilder<MemeTemplate> builder)
        {
            builder.Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(m => m.TextRectangleOrigin)
                .IsRequired();

            builder.Property(m => m.TextRectangleMaxHeight)
                .IsRequired();

            builder.Property(m => m.TextRectangleMaxWidth)
                .IsRequired();

            builder.HasData(
                new MemeTemplate
                {
                    Id = -1,
                    Name = "Test",
                    TextRectangleOrigin = new Point(10,10) { SRID = 4326 },
                    TextRectangleMaxHeight = 250,
                    TextRectangleMaxWidth = 500
                });
        }
    }
}
