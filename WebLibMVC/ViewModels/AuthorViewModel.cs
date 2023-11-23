using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Country { get; set; }
    }
}
