using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppFinal.Models
{
    public class VideoGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VideoGameId { get; set; }

        public DateTime ReleaseDate { get; set; }


        public string ?Genre { get; set; }


        public string ?Platforms { get; set; }


        public double Rating { get; set; }
    }
}
