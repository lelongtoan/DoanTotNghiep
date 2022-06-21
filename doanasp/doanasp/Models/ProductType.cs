using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace doanasp.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Product Type Name")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Status")]
        [DefaultValue(true)]
        public bool Status { get; set; } = true;

        // Collection reference property cho khóa ngoại từ Product
        public List<Product> Products { get; set; }
    }
}
