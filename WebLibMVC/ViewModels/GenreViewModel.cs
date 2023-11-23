using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class GenreViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(15)]
        public string Name { get; set; }
    }
}
