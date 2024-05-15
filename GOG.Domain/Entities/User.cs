using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOG.Domain.Entities.Common;

namespace GOG.Domain.Entities;

public class User : BaseAuditableEntity
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty; // Store hashed passwords only for security
    public string ProfilePictureUrl { get; set; } = string.Empty;

    public List<Comment>? Comments { get; set; } = new List<Comment>();
    public List<Media> MediaItems { get; set; } = new List<Media>();

}

