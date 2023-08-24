using System.ComponentModel.DataAnnotations;

namespace project.viewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "this field is required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [DataType(DataType.Password)]

        public int password { get; set; }
        public string message { get; set; }
    }
}
