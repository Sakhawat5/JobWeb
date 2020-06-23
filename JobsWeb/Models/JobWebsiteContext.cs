using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsWeb.Models
{
    public class JobWebsiteContext : DbContext
    {
        public JobWebsiteContext(DbContextOptions<JobWebsiteContext> options) : base(options)
        {

        }
     
        public DbSet<Job> Jobs { get; set; }
    }
}
