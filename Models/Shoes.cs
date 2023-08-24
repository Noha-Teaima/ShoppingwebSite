using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Shoes
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public string description { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public int price { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public string img { get; set; }
        

        List<UserShoes> userShoes { get; set; }



    }
}
