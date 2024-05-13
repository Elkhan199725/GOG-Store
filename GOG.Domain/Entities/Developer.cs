using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class Developer : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; }
    // You can add additional fields as needed, such as:
    public string Website { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public List<Game>? Games { get; set; } = new List<Game>(); // Navigation property for related games
}

