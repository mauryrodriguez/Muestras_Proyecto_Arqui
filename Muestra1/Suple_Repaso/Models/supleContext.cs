using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Suple_Repaso.Models
{
    public partial class supleContext : DbContext
    {
        public supleContext()
        {
        }

        public supleContext(DbContextOptions<supleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MAURY\\MSSQLSERVER01; Database=suple; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.IdEstudiante)
                    .HasName("PK__estudian__AEFFDBC591916570");

                entity.ToTable("estudiante");

                entity.Property(e => e.IdEstudiante).HasColumnName("idEstudiante");

                entity.Property(e => e.ApellidoEstudiante)
                    .IsRequired()
                    .HasColumnName("apellidoEstudiante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CiEstudiante)
                    .HasColumnName("ciEstudiante")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FechaNacEstudiante)
                    .HasColumnName("fechaNacEstudiante")
                    .HasColumnType("date");

                entity.Property(e => e.IdMateria).HasColumnName("idMateria");

                entity.Property(e => e.IdProfesor).HasColumnName("idProfesor");

                entity.Property(e => e.MailEstudiante)
                    .IsRequired()
                    .HasColumnName("mailEstudiante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEstudiante)
                    .IsRequired()
                    .HasColumnName("nombreEstudiante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Estudiante)
                    .HasForeignKey(d => d.IdMateria)
                    .HasConstraintName("FK__estudiant__idMat__3B75D760");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany(p => p.Estudiante)
                    .HasForeignKey(d => d.IdProfesor)
                    .HasConstraintName("FK__estudiant__idPro__3C69FB99");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.IdMateria)
                    .HasName("PK__materia__4B740AB35F552C61");

                entity.ToTable("materia");

                entity.Property(e => e.IdMateria).HasColumnName("idMateria");

                entity.Property(e => e.NombreMateria)
                    .IsRequired()
                    .HasColumnName("nombreMateria")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.HasKey(e => e.IdNota)
                    .HasName("PK__nota__AD5F462E9C020973");

                entity.ToTable("nota");

                entity.Property(e => e.IdNota).HasColumnName("idNota");

                entity.Property(e => e.IdEstudiante).HasColumnName("idEstudiante");

                entity.Property(e => e.IdMateria).HasColumnName("idMateria");

                entity.Property(e => e.Nota1).HasColumnName("nota");

                entity.HasOne(d => d.IdEstudianteNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.IdEstudiante)
                    .HasConstraintName("FK__nota__idEstudian__3F466844");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.IdMateria)
                    .HasConstraintName("FK__nota__idMateria__403A8C7D");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(e => e.IdProfesor)
                    .HasName("PK__profesor__E4BBA60479209C16");

                entity.ToTable("profesor");

                entity.Property(e => e.IdProfesor).HasColumnName("idProfesor");

                entity.Property(e => e.ApellidoProfesor)
                    .IsRequired()
                    .HasColumnName("apellidoProfesor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CiProfesor)
                    .HasColumnName("ciProfesor")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MailProfesor)
                    .IsRequired()
                    .HasColumnName("mailProfesor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProfesor)
                    .IsRequired()
                    .HasColumnName("nombreProfesor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProfesor)
                    .HasColumnName("tipoProfesor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
