using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Class
{
    class CashierOrder
    {
        public int Idoder { get; set; }
        public int Customerid { get; set; }
        public string Prodid { get; set; }
        public string Prodname { get; set; }
        public string Category { get; set; }
        public float Regularprice { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public DateTime Dateorder { get; set; }
    }
}
