using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VineForceDemo.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string? CountryName { get; set; }

        [Display(Name = "Region")]
        public string? Region { get; set; }

        [Display(Name = "Head of Country")]
        public string? HeadOfCountry { get; set; }
    }
}
