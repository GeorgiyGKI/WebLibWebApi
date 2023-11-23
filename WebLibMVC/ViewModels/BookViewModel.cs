using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(0, 9999)]
        public int Year { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int GenreId { get; set; }
        public string? GenreName { get; set; }
        [Range(1, 99)]
        public int Quantity { get; set; }
        public IFormFile? Image { get; set; }
        public byte[]? ImageData { get; set; }

        public List<SelectListItem>? Authors { get; set; } = new List<SelectListItem>();
        public List<SelectListItem>? Genres { get; set; } = new List<SelectListItem>();
    }
}
