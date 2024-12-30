using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_OTP
{
    public class Email
    {
        [Required]
        public string email { get; set; } = "";
    }
}
