namespace CourseManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CourseManagerEntities : DbContext
    {
        public CourseManagerEntities()

            : base("name=CourseManagerContext")
        {
        }

        public virtual DbSet<ActionLinks> ActionLinks { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<CourseBiao> CourseBiao { get; set; }
        public virtual DbSet<kecheng> kecheng { get; set; }
        public virtual DbSet<SideBars> SideBars { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<xuesheng> xuesheng { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionLinks>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<ActionLinks>()
                .Property(e => e.Ation)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SideBars>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<SideBars>()
                .Property(e => e.Ation)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<xuesheng>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
