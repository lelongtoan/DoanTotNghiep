using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doanasp.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        // Navigation reference property cho khóa ngoại đến Account 
        [DisplayName("Customer")]
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }

        [DisplayName("Employee")]
        public Employee Employee { get; set; }

        [DisplayName("Createddate")]
        [DataType(DataType.DateTime)]
        public DateTime Createddate { get; set; } = DateTime.Now;

        [DisplayName("ShippingAddress")]
        public string ShippingAddress { get; set; }

        [DisplayName("ShippingPhone")]
        public string ShippingPhone { get; set; }

        [DisplayName("Total Price")]
        public int Total { get; set; }

        [DisplayName("Còn hiệu lực")]
        [DefaultValue(true)]
        public bool Status { get; set; } = true;

        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public DateTime IssueDate { get; internal set; }
    }
}
