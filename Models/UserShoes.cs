using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace project.Models
{
    public class UserShoes
    {
        [Key ,Column(Order =1)]
        [ForeignKey("shoes")]
        public int shoesId { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("user")]
        public int? userId { get; set; }
        public User user { get; set; }
        public Shoes shoes { get; set; }


    }
}
