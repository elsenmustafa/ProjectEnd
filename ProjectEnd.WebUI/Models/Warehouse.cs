
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEnd.WebUI.Models
{
    public class Warehouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Adress { get; set; }
        public ICollection<AppUsers> appUsers { get; set; }
        public ICollection<Declarations> Declarations { get; set; }
    }
}
