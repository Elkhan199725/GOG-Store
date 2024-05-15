using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOG.Domain.Entities;

public class NewsArticleCategory
{
    public int NewsArticleId { get; set; }
    public NewsArticle? NewsArticle { get; set; }
    public int NewsCategoryId { get; set; }
    public NewsCategory? NewsCategory { get; set; }
}