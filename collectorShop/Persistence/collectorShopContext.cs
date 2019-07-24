using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence
{
    public partial class collectorShopContext : DbContext
    {
        public collectorShopContext()
        {
        }

        public collectorShopContext(DbContextOptions<collectorShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anuncio> Anuncio { get; set; }
        public virtual DbSet<Anunciomodelo> Anunciomodelo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Envio> Envio { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Subcategoria> Subcategoria { get; set; }
        public virtual DbSet<Troca> Troca { get; set; }
        public virtual DbSet<Trocaanuncio> Trocaanuncio { get; set; }
        public virtual DbSet<Trocamodelo> Trocamodelo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Usuariocategoria> Usuariocategoria { get; set; }
        public virtual DbSet<Usuariosubcategoria> Usuariosubcategoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         /*   if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=collectorShop");
            } */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Anuncio>(entity =>
            {
                entity.HasKey(e => new { e.CodAnuncio, e.CodUsuario });

                entity.ToTable("anuncio", "collectorshop");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_anuncio_usuario1_idx");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.QuantAnunciada)
                    .HasColumnName("quantAnunciada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuantDisponivel)
                    .HasColumnName("quantDisponivel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("set('ATIVO','INATIVO')");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Anuncio)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_anuncio_usuario1");
            });

            modelBuilder.Entity<Anunciomodelo>(entity =>
            {
                entity.HasKey(e => new { e.CodAnuncio, e.CodModelo });

                entity.ToTable("anunciomodelo", "collectorshop");

                entity.HasIndex(e => e.CodAnuncio)
                    .HasName("fk_Anuncio_has_modelo_Anuncio1_idx");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_Anuncio_has_modelo_modelo1_idx");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Anunciomodelo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Anuncio_has_modelo_modelo1");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.CodCategoria);

                entity.ToTable("categoria", "collectorshop");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => new { e.CodCompra, e.CodUsuario, e.CodAnuncio });

                entity.ToTable("compra", "collectorshop");

                entity.HasIndex(e => e.CodAnuncio)
                    .HasName("fk_compra_anuncio1_idx");

                entity.HasIndex(e => e.CodEnvio)
                    .HasName("fk_Compra_Envio1_idx");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_compra_modelo1_idx");

                entity.HasIndex(e => e.CodPagamento)
                    .HasName("fk_Compra_Pagamento1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_compra_usuario1_idx");

                entity.Property(e => e.CodCompra)
                    .HasColumnName("codCompra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPagamento)
                    .HasColumnName("codPagamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.ValorTotal).HasColumnName("valorTotal");

                entity.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");

                entity.HasOne(d => d.CodEnvioNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CodEnvio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Envio1");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_compra_modelo1");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Pagamento1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_compra_usuario1");
            });

            modelBuilder.Entity<Envio>(entity =>
            {
                entity.HasKey(e => e.CodEnvio);

                entity.ToTable("envio", "collectorshop");

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Preco).HasColumnName("preco");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.CodModelo);

                entity.ToTable("modelo", "collectorshop");

                entity.HasIndex(e => e.CodSubcategoria)
                    .HasName("fk_Modelo_SubCategoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Modelo_Usuario1_idx");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ano)
                    .IsRequired()
                    .HasColumnName("ano")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Colecao)
                    .IsRequired()
                    .HasColumnName("colecao")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.QuantTiragem)
                    .IsRequired()
                    .HasColumnName("quantTiragem")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasKey(e => e.CodPagamento);

                entity.ToTable("pagamento", "collectorshop");

                entity.Property(e => e.CodPagamento)
                    .HasColumnName("codPagamento")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Opcao)
                    .IsRequired()
                    .HasColumnName("opcao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<Subcategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodSubcategoria, e.CodCategoria });

                entity.ToTable("subcategoria", "collectorshop");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("fk_subCategoria_categoria1_idx");

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(d => d.CodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_subCategoria_categoria1");
            });

            modelBuilder.Entity<Troca>(entity =>
            {
                entity.HasKey(e => new { e.CodTroca, e.CodUsuario });

                entity.ToTable("troca", "collectorshop");

                entity.HasIndex(e => e.CodEnvio)
                    .HasName("fk_Troca_Envio1_idx");

                entity.HasIndex(e => e.CodPagamento)
                    .HasName("fk_Troca_Pagamento1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_troca_usuario1_idx");

                entity.Property(e => e.CodTroca)
                    .HasColumnName("codTroca")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPagamento)
                    .HasColumnName("codPagamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("quantidade")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodEnvioNavigation)
                    .WithMany(p => p.Troca)
                    .HasForeignKey(d => d.CodEnvio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_Envio1");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Troca)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_Pagamento1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Troca)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_troca_usuario1");
            });

            modelBuilder.Entity<Trocaanuncio>(entity =>
            {
                entity.HasKey(e => new { e.CodTroca, e.CodAnuncio });

                entity.ToTable("trocaanuncio", "collectorshop");

                entity.HasIndex(e => e.CodAnuncio)
                    .HasName("fk_Troca_has_Anuncio_Anuncio1_idx");

                entity.HasIndex(e => e.CodTroca)
                    .HasName("fk_Troca_has_Anuncio_Troca1_idx");

                entity.Property(e => e.CodTroca)
                    .HasColumnName("codTroca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Trocamodelo>(entity =>
            {
                entity.HasKey(e => new { e.TrocaCodTroca, e.CodModelo });

                entity.ToTable("trocamodelo", "collectorshop");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_Troca_has_Modelo_Modelo1_idx");

                entity.HasIndex(e => e.TrocaCodTroca)
                    .HasName("fk_Troca_has_Modelo_Troca1_idx");

                entity.Property(e => e.TrocaCodTroca)
                    .HasColumnName("trocaCodTroca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodModelo).HasColumnType("int(11)");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Trocamodelo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Modelo_Modelo1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario);

                entity.ToTable("usuario", "collectorshop");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Administrador)
                    .HasColumnName("administrador")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("cep")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuariocategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodCategoria, e.CodUsuario });

                entity.ToTable("usuariocategoria", "collectorshop");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("fk_Usuario_has_Categoria_Categoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_usuarioCategoria_usuario1_idx");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.Usuariocategoria)
                    .HasForeignKey(d => d.CodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_has_Categoria_Categoria1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Usuariocategoria)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarioCategoria_usuario1");
            });

            modelBuilder.Entity<Usuariosubcategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodSubcategoria });

                entity.ToTable("usuariosubcategoria", "collectorshop");

                entity.HasIndex(e => e.CodSubcategoria)
                    .HasName("fk_usuarioSubCategoria_subCategoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_usuarioSubCategoria_usuario1_idx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Usuariosubcategoria)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarioSubCategoria_usuario1");
            });
        }

        public static implicit operator collectorShopContext(bancocollectorContext v)
        {
            throw new NotImplementedException();
        }
    }
}
