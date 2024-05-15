using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOG.Domain.Entities.Common;

namespace GOG.Domain.Entities;

public class Genre : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<GameGenre>? GameGenres { get; set; } = new List<GameGenre>();
}