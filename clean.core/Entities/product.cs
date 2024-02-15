using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean.core.Entities
{
    public class product
    {
        [Key]
        public string Barcode { get; set; }
        public int Price { get; set; }
        public string ProdName { get; set; }
        public string Brand { get; set; }
    }
}
