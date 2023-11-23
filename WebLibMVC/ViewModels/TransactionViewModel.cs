using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebLibMVC.ViewModels
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }

        public string? ReaderName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int TransactionStatusId { get; set; } = 1;
        public string? TransactionStatusName { get; set; }

        public List<SelectListItem> Books { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TransactionStatuses { get; set; } = new List<SelectListItem>();

    }
}
