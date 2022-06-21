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
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string SKU { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Price (VNĐ)")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [DefaultValue(0)]
        public int Price { get; set; } = 0;

        [DisplayName("Stock")]
        [DefaultValue(0)]
        public int Stock { get; set; } = 0;

        public int ProducerId { get; set; }

        // Navigation reference property cho khóa ngoại đến ProductType
        [DisplayName("Producer")]
        public Producer Producer { get; set; }
        public int ProductTypeId { get; set; }

        // Navigation reference property cho khóa ngoại đến ProductType
        [DisplayName("Product Type")]
        public ProductType ProductType { get; set; }

        [DisplayName("Discount")]
        public int Discount { get; set; }

        [DisplayName("Image")]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime Createddate { get; set; } = DateTime.Now;

        [DisplayName("Status")]
        [DefaultValue(true)]
        public bool Status { get; set; } = true;

        // Collection reference property cho khóa ngoại từ Cart
        public List<Cart> Carts { get; set; }

        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<InvoiceDetail> InvoiceDetails { get; set; }

        public List<ProductDetail> productDetails { get; set; }
        
    }
}
