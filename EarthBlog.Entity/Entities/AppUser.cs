using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EarthBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("24760B47-F5AE-4CF6-BFEE-B17FCAB0E9F1");

		public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
