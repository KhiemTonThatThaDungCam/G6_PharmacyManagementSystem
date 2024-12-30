using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_OTP
{
    public class OTP
    {
        [Required]
        public string otp { get; set; } = "";
        [Required]
        public int iduser { get; set; }
        [Required]
        public string username { get; set; } = "";
        [Required]
        public string email { get; set; } = "";
        [Required]
        public string role { get; set; } = "";
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime dateregister { get; set; }
    }
}
