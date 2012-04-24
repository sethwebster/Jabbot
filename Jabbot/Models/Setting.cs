using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Jabbot.Models
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Value { get; set; }
        public HostedSprocket Sprocket { get; set; }
    }
}
