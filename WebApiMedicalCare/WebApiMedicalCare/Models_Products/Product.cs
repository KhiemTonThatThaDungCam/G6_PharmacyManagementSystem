using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Products
{
    public class Product
    {
        [Required]
        public int idpro { get; set; } 
        [Required]
        public string proid { get; set; } = "";
        [Required]
        public string proname { get; set; } = "";
        [Required]
        public string category { get; set; } = "";
        [Required]
        public float price { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public string image { get; set; } = "";
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime dateinsert { get; set; }
    }
}
