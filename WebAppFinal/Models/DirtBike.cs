using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppFinal.Models 
{
    public class DirtBike 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DirtBikeId { get; set; }
        
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Displacement { get; set; }
        public string Description { get; set; }
    }
}