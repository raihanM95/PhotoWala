using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoWala.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(11)]
        public string Phone { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        public string Address { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
