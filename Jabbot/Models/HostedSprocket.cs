using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Jabbot.Models
{
    public class HostedSprocket
    {
        [Key]
        public int HostedSprocketId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
    }
}
