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
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.HasKey(x => x.SiteId);

            builder.Property(x => x.SiteBaşlık)
                .IsRequired();

            builder.Property(x => x.SiteTitle)
                .IsRequired();

            builder.Property(x => x.SiteDesc)
                .IsRequired();

            builder.Property(x => x.SiteMail)
                .IsRequired();
        }
    }
}
