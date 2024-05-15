using GOG.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class NewsCategory : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public List<NewsArticleCategory> NewsArticleCategories { get; set; } = new List<NewsArticleCategory>();
}