using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Department> department { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DepartmentId);
                entity.Property(d => d.DepartmentName).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(a => a.EmployeeId);
               
            });

            modelBuilder.Entity<Employees>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employee) // Navigation property on the Department entity
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
