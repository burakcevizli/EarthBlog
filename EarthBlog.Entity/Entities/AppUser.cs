using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace EarthBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid> , IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("5f802c42-c9ef-4409-aac3-129d70a69c33");

		public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
