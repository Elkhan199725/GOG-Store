using GOG.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class NewsArticle : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishedDate { get; set; }
    public List<Media> MediaItems { get; set; } = new List<Media>();
    public List<NewsArticleCategory> NewsArticleCategories { get; set; } = new List<NewsArticleCategory>();
    public List<NewsArticleTag> NewsArticleTags { get; set; } = new List<NewsArticleTag>();
}