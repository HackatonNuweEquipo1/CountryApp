using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace HackatonFundacionEsplai.Entities
{
    public class Region
    {
        [Required]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public List<Country> Countries { get; set; } = new List<Country>();
    }
}
