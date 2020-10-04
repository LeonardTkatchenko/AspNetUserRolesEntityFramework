using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspNetUserRolesEntityFramework.Models;

namespace AspNetUserRolesEntityFramework.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AspNetUserRolesEntityFramework.Models.DiscussionForum> DiscussionForum { get; set; }
    }
}
