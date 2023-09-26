using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroservicetwo.Models;

public class ReviewDbContext : DbContext
{

    public ReviewDbContext(DbContextOptions<ReviewDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Review> Reviews { get; set; }
}
