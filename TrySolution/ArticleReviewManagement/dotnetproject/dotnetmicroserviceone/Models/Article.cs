using System;
using System.Collections.Generic;

namespace dotnetmicroserviceone.Models;
public class Article
{
    public int ArticleID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public DateTime PublicationDate { get; set; }
}
