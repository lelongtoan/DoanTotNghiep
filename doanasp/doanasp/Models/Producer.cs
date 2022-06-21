using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using doanasp.Models;

namespace doanasp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Producer Name")]
        public string Name { get; set; }

        [DisplayName("Status")]

        public bool Status { get; set; } = true;

        public List<Product> products { get; set; }

    }
}
