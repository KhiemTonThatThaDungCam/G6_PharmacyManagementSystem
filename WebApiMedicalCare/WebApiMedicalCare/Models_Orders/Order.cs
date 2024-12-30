using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiMedicalCare.Models_Orders
{
    public class Order
    {
        [Required]
        public int idoder { get; set; }
        [Required]
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
