using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace project.Models
{
    public class UserClothes
    {
        [Key, Column(Order = 1)]
        [ForeignKey("user")]
        public int? userId { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("clothes")]
        public int clothesId { get; set; }

       public User user { get; set; }
        public Clothes clothes { get; set; }

    }
}
