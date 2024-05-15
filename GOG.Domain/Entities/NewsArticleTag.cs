using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class NewsArticleTag
{
    public int NewsArticleId { get; set; }
    public NewsArticle? NewsArticle { get; set; }
    public int NewsTagId { get; set; }
    public NewsTag? NewsTag { get; set; }
}
