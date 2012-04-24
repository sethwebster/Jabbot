using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Jabbot.Models
{
    public interface IJabbotDataContext
    {
        IDbSet<HostedSprocket> HostedSprockets { get; set; }
        IDbSet<Setting> Settings { get; set; }
        int SaveChanges();
    }
}
