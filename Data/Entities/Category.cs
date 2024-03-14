using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem_Workshop.Data.Constants.DataConstans;

namespace HouseRentingSystem_Workshop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaximumLength)]
        public string Name { get; set; } = string.Empty;
    }
}
