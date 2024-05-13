using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class Comment : BaseEntity
{
    public int GameId { get; set; }
    public Game? Game { get; set; } // Navigation property to the Game
    public int UserId { get; set; }
    public User? User { get; set; } // Navigation property to the User
    public string Content { get; set; } = string.Empty;
    public DateTime PostedDate { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
    // Optionally, support threaded comments
    public int? ParentCommentId { get; set; } // Null for top-level comments
    public Comment? ParentComment { get; set; }
    public List<Comment> Replies { get; set; } = new List<Comment>(); // For nested or threaded comments
}
