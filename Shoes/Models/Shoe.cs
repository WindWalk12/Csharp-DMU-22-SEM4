using Shoes.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Shoes.Models
{
    [Shoe(ErrorMessage = "Hvis silk, så maks size er 40")]
    public class Shoe
    {
        [Display(Name = "Indtast size")]
        [Range(typeof(int), "2", "100", ErrorMessage = "Mellem 2 og 100 af gangen")]
        [Required(ErrorMessage = "Du mangler en size")]
        public int Size { get; set; }

        [Display(Name = "Indtast et matriale")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Hallå, mellem 2 og 10")]
        [Required(ErrorMessage = "Du mangler et matriale")]
        public string Material { get; set; }

        [Display(Name = "Indtast en dato")]
        [Required(ErrorMessage = "Du mangler en dato")]
        [ProductionDate(ErrorMessage = "Det må ikke være en lørdag eller søndag")]
        public DateTime ProductionDate { get; set; }

    }
}
