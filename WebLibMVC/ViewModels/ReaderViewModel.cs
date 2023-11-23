using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class ReaderViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(15)]
        //Custom attribute about phone number
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime RegistrationDate { get; set; }
    }
}
