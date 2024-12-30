using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Users
{
    public class DKUser
    {
        [Required]
        public string username { get; set; } = "";
        [Required]
        public string email { get; set; } = "";
        [Required]
        public string password { get; set; } = "";
        [Required]
        public string role { get; set; } = "";
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime dateregister { get; set; }
    }
}
