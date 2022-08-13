using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreRelationalDatabase.ManyToMany;
using EfCoreRelationalDatabase.One_to_Many;
using EfCoreRelationalDatabase.OneTwoOne;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelationalDatabase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=DESKTOP-6VEG45R;Initial Catalog=iLab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(p =>
            {
                p.HasKey(x => x.Id);
                p.Property(x => x.Id).UseIdentityColumn();
                p.Property(x => x.Price).HasColumnType("decimal(18,2)");
                p.ToTable("Products");
                p.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            });

            modelBuilder.Entity<Category>(c =>
            {
                c.HasKey(x => x.Id);
                c.Property(x => x.Id).UseIdentityColumn();

            });

            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(x => x.Id);
                s.Property(x => x.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<StudentAddress>(sa =>
            {
                sa.HasKey(x => x.Id);
                sa.HasOne(x => x.Student).WithOne(x => x.StudentAddress).HasForeignKey<StudentAddress>(x => x.Id);
            });

            modelBuilder.Entity<Course>(c =>
            {
                c.HasKey(x => x.Id);
                c.Property(x => x.Id).UseIdentityColumn();
                c.HasMany(x => x.Students).WithMany(x => x.Courses);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
