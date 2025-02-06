using System.ComponentModel.DataAnnotations;

namespace WebTestUsersCompany.ViewModels
{
    public class RoomBookingViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public string BookedBy { get; set; }
    }
}
