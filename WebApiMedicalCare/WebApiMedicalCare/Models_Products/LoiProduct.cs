using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Products
{
    public class LoiProduct
    {
        [Required]
        public string loi { get; set; } = "";
    }
}
