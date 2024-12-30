using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Orders
{
    public class AddOrder
    {
        public int customerid { get; set; }
        [Required]
        public string proid { get; set; } = "";
        [Required]
        public string proname { get; set; } = "";
        [Required]
        public string category { get; set; } = "";
        [Required]
        public float regularprice { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime dateorder { get; set; }
    }
}
