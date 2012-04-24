using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Jabbot.Models
{
    public class JabbotDataContext : DbContext, IJabbotDataContext
    {
        public IDbSet<HostedSprocket> HostedSprockets { get; set; }
        public IDbSet<Setting> Settings { get; set; }
    }
}
