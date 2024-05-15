using GOG.Domain.Entities.Common;
using GOG.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class Media : BaseAuditableEntity
{
    public int MediaOwnerId { get; set; } // The ID of the entity that owns this media
    public MediaOwnerType MediaOwnerType { get; set; } // The type of entity that owns this media
    public string Url { get; set; } = string.Empty;
    public MediaType MediaType { get; set; } // This enum will distinguish between image types and videos
    public bool IsCover { get; set; } // This flag will indicate if an image is the cover image

}

