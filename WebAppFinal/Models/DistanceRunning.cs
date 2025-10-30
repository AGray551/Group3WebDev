using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppFinal.Models
{
    public class DistanceRunning
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistanceRunningId { get; set; }

        public DateTime Date { get; set; }

        [Display(Name = "Distance (miles)")]
        public double Distance { get; set; }

        [Display(Name = "Time (minutes)")]
        public int Time { get; set; }

        [Display(Name = "Max Heart Rate (bpm)")]
        public int MaxHeartRate { get; set; }
    }
}
