using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web_ECommerce.IdentitySettings;

namespace Web_ECommerce.Configurations.IdentitySettings
{
    public class IdentitySettingConfiguration : IEntityTypeConfiguration<IdentitySetting>
    {
        public void Configure(EntityTypeBuilder<IdentitySetting> builder)
        {
            builder.ToTable(Web_ECommerceConsts.DbTablePrefix + "IdentitySettings",
                Web_ECommerceConsts.DbSchema);
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Name).IsRequired().HasMaxLength(200);

        }
    }
}