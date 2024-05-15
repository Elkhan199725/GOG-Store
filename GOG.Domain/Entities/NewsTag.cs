using GOG.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class NewsTag : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public List<NewsArticleTag> NewsArticleTags { get; set; } = new List<NewsArticleTag>();
}