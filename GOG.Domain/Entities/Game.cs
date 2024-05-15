using GOG.Domain.Entities.Common;
using GOG.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GOG.Domain.Entities;
public class Game : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public int DeveloperId { get; set; } // Foreign key to Developer entity
    public decimal Price { get; set; }
    public decimal DiscountRate { get; set; }
    public Developer? Developer { get; set; }
    public List<GameGenre> GameGenres { get; set; } = new List<GameGenre>();
    public List<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();
    public List<Media> MediaItems { get; set; } = new List<Media>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<GameRequirement> GameRequirements { get; set; } = new List<GameRequirement>(); // Add this line

    public string? CoverImage => MediaItems.FirstOrDefault(m => m.MediaType == MediaType.Image && m.IsCover)?.Url;
    public IEnumerable<string>? ImageUrls => MediaItems.Where(m => m.MediaType == MediaType.Image).Select(m => m.Url);
    public IEnumerable<string>? TrailerUrls => MediaItems.Where(m => m.MediaType == MediaType.Video).Select(m => m.Url);
}