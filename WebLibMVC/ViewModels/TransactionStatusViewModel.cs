using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class TransactionStatusViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
