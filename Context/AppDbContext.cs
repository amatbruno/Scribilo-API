using Scribilo_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Scribilo_API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Saved> Saves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(tb =>
            {
                tb.HasKey(x => x.Id);
                tb.Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
                tb.Property(x => x.Username).HasMaxLength(50);
                tb.Property(x => x.Firstname).HasMaxLength(50);
                tb.Property(x => x.Surname).HasMaxLength(50);
                tb.Property(x => x.Email).HasMaxLength(100);
                tb.Property(x => x.Password).HasMaxLength(150);
                tb.Property(x => x.Country).HasMaxLength(50);
                tb.Property(x => x.Biography).HasMaxLength(150);
                tb.HasMany(x => x.Posts).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
                tb.ToTable("users");
            });


            modelBuilder.Entity<Post>(tb =>
            {
                tb.HasKey(x => x.Id);
                tb.Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
                tb.Property(x => x.Title).HasMaxLength(50);
                tb.Property(x => x.Description).HasMaxLength(50);
                tb.Property(x => x.PublishDate).HasMaxLength(50);
                tb.Property(x => x.ModificationDate).HasMaxLength(100);
                tb.Property(x => x.Body).HasMaxLength(1000);
                tb.ToTable("posts");
            });
        }
    }
}
