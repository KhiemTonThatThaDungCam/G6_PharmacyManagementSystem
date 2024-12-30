using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Login
{
    public class LoiLogin
    {
        [Required]
        public string loi { get; set; } = "";
    }
}
