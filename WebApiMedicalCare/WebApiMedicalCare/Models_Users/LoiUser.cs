using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Users
{
    public class LoiUser
    {
        [Required]
        public string loi { get; set; } = "";
    }
}
