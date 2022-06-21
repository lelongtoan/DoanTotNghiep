using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using doanasp.Models;

namespace doanasp.Models
{
    public class Position
    {

        [Key]
        public int id { get; set; }

        [DisplayName("Position Name")]
        public string name { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; } = true;

        public List<Employee> employees { get; set; }

    }
}
