using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using doanasp.Models;

namespace doanasp.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [DisplayName("UserName")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters")]
        public string Username { get; set; }
        [DisplayName("PassWord")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Position")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public Position position { get; set; }

        [DisplayName("Pay")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public int Pay { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Phone number")]
        [RegularExpression("0\\d{9}", ErrorMessage = "SĐT không hợp lệ")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Phone { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Address { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Fullname { get; set; }

        [DisplayName("BirthDay")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public DateTime Birthday { get; set; }

        [DisplayName("Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime Createddate { get; set; } = DateTime.Now;

        [DisplayName("Is Admin")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public bool IsAdmin { get; set; }
        [DisplayName("Avatar")]
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }
        [DisplayName("Status")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public bool Status { get; set; }
        public List<Invoice> invoices { get; set; }
    }
}
