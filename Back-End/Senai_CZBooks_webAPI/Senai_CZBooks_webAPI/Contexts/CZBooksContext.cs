using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai_CZBooks_webAPI.Domains;

#nullable disable

namespace Senai_CZBooks_webAPI.Contexts
{
    public partial class CZBooksContext : DbContext
    {
        public CZBooksContext()
        {
        }

        public CZBooksContext(DbContextOptions<CZBooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Instituico> Instituicoes { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=RAFAEL; initial catalog=CZBooks; user id=sa; pwd=1199700265Ra;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autore>(entity =>
            {
                entity.HasKey(e => e.IdAutores)
                    .HasName("PK__autores__7908E7D5F9F4FA4A");

                entity.ToTable("autores");

                entity.Property(e => e.IdAutores).HasColumnName("idAutores");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__categori__8A3D240CDE443642");

                entity.ToTable("categorias");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Categoria1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<Instituico>(entity =>
            {
                entity.HasKey(e => e.IdInstituicao)
                    .HasName("PK__institui__8EA7AB0005F68773");

                entity.ToTable("instituicoes");

                entity.Property(e => e.IdInstituicao).HasColumnName("idInstituicao");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.NomeInstituicao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomeInstituicao");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.IdLivro)
                    .HasName("PK__livros__63C546D7FACD682A");

                entity.ToTable("livros");

                entity.HasIndex(e => e.Titulo, "UQ__livros__38FA640F0DDD7AB0")
                    .IsUnique();

                entity.Property(e => e.IdLivro).HasColumnName("idLivro");

                entity.Property(e => e.DataDaPublicacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dataDaPublicacao");

                entity.Property(e => e.IdAutor).HasColumnName("idAutor");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("preco");

                entity.Property(e => e.Sinopse)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sinopse");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__livros__idAutor__4316F928");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__livros__idCatego__4222D4EF");
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tiposUsu__03006BFF33FC085B");

                entity.ToTable("tiposUsuarios");

                entity.HasIndex(e => e.TipoUsuario, "UQ__tiposUsu__A9585C05C2B0151B")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__usuarios__645723A64611B703");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.NomeUsuario, "UQ__usuarios__8C9D1DE58CEBA3D8")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeUsuario");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__usuarios__idTipo__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
