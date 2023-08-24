using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Clothes
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public int price { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public string img { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public string description { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public string category { get; set; }

        List<UserClothes> userClothes { get; set; } 

    }
}
