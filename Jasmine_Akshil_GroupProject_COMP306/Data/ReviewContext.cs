using Jasmine_Akshil_GroupProject_COMP306.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jasmine_Akshil_GroupProject_COMP306.Data
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> opt) : base(opt)
        {

        }
        public DbSet<Review> Reviews { get; set; }
    }
}
