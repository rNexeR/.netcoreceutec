using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.Models
{
    public class UserInfoModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string Username { get; set; }

        [Required]

        public string Email { get; set; }
    }
}
