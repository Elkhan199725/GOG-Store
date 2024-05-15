using GOG.Domain.Entities.Common;
using GOG.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;
public class GameRequirement : BaseAuditableEntity
{
    public int GameId { get; set; }
    public Game? Game { get; set; }
    public RequirementType RequirementType { get; set; } // Enum to distinguish between Minimum and Recommended requirements
    public string OS { get; set; } = string.Empty;
    public string Processor { get; set; } = string.Empty;
    public string Memory { get; set; } = string.Empty;
    public string Graphics { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;
    public string AdditionalNotes { get; set; } = string.Empty;
}
