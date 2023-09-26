using System;
using System.Collections.Generic;

namespace dotnetmicroservicetwo.Models;
public class Review
{
    public int ReviewID { get; set; }
    public string ArticleID { get; set; }
    public string ReviewerName { get; set; }
    public string Comments { get; set; }
    public int Rating { get; set; }

}
