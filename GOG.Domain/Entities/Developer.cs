using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOG.Domain.Entities.Common;

namespace GOG.Domain.Entities;

public class Developer : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;  
    public string Website { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public List<Game>? Games { get; set; } = new List<Game>();
}

