using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace doanasp.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }

        // Navigation reference property cho khóa ngoại đến Product
        [DisplayName("Product")]
        public Product Product { get; set; }

        [DisplayName("Import Price")]
        public int Importprice { get; set; }

        [DisplayName("Import Quantity")]
        public int Importquantity { get; set; }

        [DisplayName("Total Price")]

        public int Totalprice { get; set; }
    }
}
