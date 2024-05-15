using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOG.Domain.Entities.Common;

namespace GOG.Domain.Entities;

public class Comment : BaseAuditableEntity
{
    public int GameId { get; set; }
    public Game? Game { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime PostedDate { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }

    public int? ParentCommentId { get; set; } 
    public Comment? ParentComment { get; set; }
    public List<Comment>? Replies { get; set; } = new List<Comment>();
}
