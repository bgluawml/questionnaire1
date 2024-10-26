using Microsoft.EntityFrameworkCore;
using questionnaire1.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Data
{
    public class QuestionContext : DbContext
    {
        public QuestionContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Questions");
                entity.HasKey(q => q.Id);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answers");
                entity.HasKey(a => a.Id);
                entity.HasOne(a => a.Question).WithMany(q => q.Answers).HasForeignKey(a => a.QuestionId);
            });
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}