using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="this field is required")]
        public string fname { get; set; }
        [Required(ErrorMessage = "this field is required")]

        public string lname { get; set; }
        [Required(ErrorMessage = "this field is required")]

        public string email { get; set; }
        [Required(ErrorMessage = "this field is required")]
        public int password { get; set; }
        [Compare("password")]
        [NotMapped]
        [Required(ErrorMessage = "this field is required")]

        public int confirmedPassword { get; set; }
        [Required(ErrorMessage = "this field is required")]

        public int phone { get; set; }
        [Required(ErrorMessage = "this field is required")]

        public int age { get; set; }


        List<UserClothes> userClothes { get; set; }

        List<UserShoes> userShoes { get; set; }

    }
}
