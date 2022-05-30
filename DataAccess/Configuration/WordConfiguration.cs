using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.HasKey(x => x.WordId);

            builder.Property(x => x.WordTitle)
                .IsRequired();

            builder.Property(x => x.WordKeyword)
                .IsRequired();

            builder.Property(x => x.Photo);

            builder.Property(x => x.KısaAçıklama)
                .IsRequired();

            builder.Property(x => x.UzunAçıklama)
                .IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(y => y.Words)
                .HasForeignKey(x => x.CategoryId);
    }
    }
}
