using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_OTP
{
    public class LoiOTP
    {
        [Required]
        public string loi { get; set; } = "";
    }
}
