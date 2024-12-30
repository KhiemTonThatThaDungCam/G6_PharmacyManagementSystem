using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Categories
{
    public class LoiCategory
    {
        [Required]
        public string loi { get; set; } = "";
    }
}
