using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using doanasp.Models;

namespace doanasp.Models
{
    public class InvoiceDetail
    {
        [Key]
        public int Id { get; set; }

        public int InvoiceId { get; set; }

        // Navigation reference property cho khóa ngoại đến Invoice
        [DisplayName("Invoice")]
        public Invoice Invoice { get; set; }

        public int ProductId { get; set; }

        // Navigation reference property cho khóa ngoại đến Product
        [DisplayName("Product")]
        public Product Product { get; set; }

        [DisplayName("Quantity")]
        [DefaultValue(1)]
        public int Quantity { get; set; } = 1;

        [DisplayName("UnitPrice")]
        [DefaultValue(0)]
        public int UnitPrice { get; set; } = 0;

        [DisplayName("Discount")]
        public int Discount { get; set; }

        [DisplayName("Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime Createddate { get; set; } = DateTime.Now;
    }
}
