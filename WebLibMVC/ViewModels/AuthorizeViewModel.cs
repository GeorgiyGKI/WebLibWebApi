using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class AuthorizeViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Password { get; set; }
    }
}
