using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using doanasp.Models;

namespace doanasp.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }


        // Navigation reference property cho khóa ngoại đến Account
        [DisplayName("Khách hàng")]
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        // Navigation reference property cho khóa ngoại đến Product
        [DisplayName("Sản phẩm")]
        public Product Product { get; set; }

        public int ProductId { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DefaultValue(1)]
        [DisplayName("Số Lượng")]
        public int Quantity { get; set; }
    }
}
