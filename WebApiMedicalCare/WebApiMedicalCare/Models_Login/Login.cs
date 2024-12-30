using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Login
{
    public class Login
    {
        [Required]
        public string username { get; set; } = "";
        [Required]
        public string password { get; set; } = "";
    }
}
