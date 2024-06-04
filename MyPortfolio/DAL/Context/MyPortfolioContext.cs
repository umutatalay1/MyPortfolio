
using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;
using System.Data.Common;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext    
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NL99QED; initial Catalog=MyPortfolioDb; integrated Security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
