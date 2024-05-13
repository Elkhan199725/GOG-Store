using GOG.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class Media : BaseEntity
{
    public int GameId { get; set; }
    public Game? Game { get; set; }
    public string Url { get; set; } = string.Empty;
    public MediaType MediaType { get; set; } // This enum will distinguish between image types and videos
    public bool IsCover { get; set; } // This flag will indicate if an image is the cover image
}
