using System.ComponentModel.DataAnnotations;

namespace WebApiMedicalCare.Models_Transactions
{
    public class Transaction
    {
        [Required]
        public int idstrans { get; set; }
        [Required]
        public int customerid { get; set; }
        [Required]
        public string proid { get; set; } = "";
        [Required]
        public float totalprice{ get; set; }
        [Required]
        public string status { get; set; } = "";
        [Required]
        public DateTime datestrans { get; set; }
    }
}
