using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodWebAppCore.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required, Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Address { get; set; }

        [Required, Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
