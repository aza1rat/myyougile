using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyYouGile.Entities
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Perfomance> Perfomance { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Project)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.ProjectCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Assignment)
                .WithRequired(e => e.Project)
                .HasForeignKey(e => e.AssignmentProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Perfomance)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stage>()
                .HasMany(e => e.Perfomance)
                .WithRequired(e => e.Stage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Perfomance)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.PerfomanceStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Perfomance1)
                .WithRequired(e => e.Status1)
                .HasForeignKey(e => e.PerfomanceStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Assignment)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.AssignmentUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Perfomance)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
