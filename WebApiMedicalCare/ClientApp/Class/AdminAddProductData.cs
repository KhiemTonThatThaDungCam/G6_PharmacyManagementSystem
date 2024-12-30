using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Class
{
    class AdminAddProductData
    {
        public int Idpro { get; set; }
        public string Proid { get; set; }
        public string Proname { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public DateTime DateInsert { get; set; }
    }
}
