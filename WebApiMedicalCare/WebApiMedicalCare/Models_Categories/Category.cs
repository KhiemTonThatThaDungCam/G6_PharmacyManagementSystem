using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Categories
{
    public class Category
    {
        [Required]
        public int idcategory { get; set; }
        [Required]
        public string category { get; set; } = "";
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime dateinsert { get; set; }
    }
}
