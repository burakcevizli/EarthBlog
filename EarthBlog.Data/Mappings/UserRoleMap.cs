using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EarthBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("66D01B81-288C-44AA-A8B1-B021D7041AF5"),
                RoleId = Guid.Parse("A50A6928-FE5B-4895-B570-EBCA1FEE4140")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("8DE8558E-A1F2-40C2-8481-770D75A8F88A"),
                RoleId = Guid.Parse("811B6955-AB4D-4C07-9887-44905E5CDD74"),
            });
        }
    }
}
