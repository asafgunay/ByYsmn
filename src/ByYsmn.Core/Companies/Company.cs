using ByYsmn.Core.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace ByYsmn.Core.Companies
{
    public class Company : Entity<Guid>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        public string Address { get; set; }
        public string WebSiteUrl { get; set; }
        public string Email { get; set; }

    }
}
