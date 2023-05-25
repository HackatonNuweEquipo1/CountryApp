using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HackatonFundacionEsplai.Entities
{
    public class Country
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Precision(2)]
        public decimal Population { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal HDI { get; set; }
        [Precision(2)]
        [AllowNull]
        public string GDP { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal CroplandFootprint { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal GrazzingFootprint { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal ForestFootprint { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal CarbonFootprint { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal FishFootprint { get; set; }
        [Precision(2)]
        public decimal TotalEcological { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal Cropland { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal GrazingLand { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal ForestLand { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal FishingWater { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal UrbanLand { get; set; }
        [Precision(2)]
        public decimal TotalBiocapacity { get; set; }
        [Precision(2)]
        [AllowNull]
        public decimal BiocapacityDeficit { get; set; }
        [Precision(2)]
        public decimal EarthRequired { get; set; }
        [Precision(2)]
        public decimal CountriesRequired { get; set; }
        [StringLength(2)]
        public string DataQuality { get; set; }

        public int RegionId { get; set; }
    }
}
