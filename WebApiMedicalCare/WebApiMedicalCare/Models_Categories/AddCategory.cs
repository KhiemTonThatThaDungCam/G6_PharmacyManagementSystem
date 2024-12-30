using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Categoties
{
    public class AddCategory
    {
        [Required]
        public string category { get; set; } = "";
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime dateinsert { get; set; }

    }
}
