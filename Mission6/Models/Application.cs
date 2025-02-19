using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Mission6.Models
{
    public class Application
    {
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("Categories")]
        public int? CategoryId { get; set; } 
        public Categories? Category { get; set; }


        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2100, ErrorMessage = "Enter a valid year.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited is required.")]
        public int Edited { get; set; }

        [Required(ErrorMessage = "Copied To Plex is required.")]
        public int CopiedToPlex { get; set; }

        public string? LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }

        
    }
}
