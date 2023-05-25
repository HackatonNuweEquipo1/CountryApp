using System.ComponentModel.DataAnnotations;

namespace HackatonFundacionEsplai.Entities.Dto
{
    public class RegionDto
    {
        [Required]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
