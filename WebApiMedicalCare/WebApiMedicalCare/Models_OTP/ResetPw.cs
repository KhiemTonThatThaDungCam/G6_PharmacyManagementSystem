using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_OTP
{
    public class ResetPw
    {
        [Required]
        public string email { get; set; } = "";
        [Required]
        public string password { get; set; } = "";
    }
}
