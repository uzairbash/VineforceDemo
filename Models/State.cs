using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace VineForceDemo.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "State")]
        public string? StateName { get; set; }


        [Required]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

        [Display(Name = "Head of State")]
        public string? HeadOfState { get; set; }
    }
}
