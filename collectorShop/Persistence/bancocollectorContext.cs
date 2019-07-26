using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using Model
namespace Persistence
{
    public partial class bancocollectorContext : DbContext
    {
        public bancocollectorContext()
        {
        }

        public bancocollectorContext(DbContextOptions<bancocollectorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAnuncio> Anuncio { get; set; }
        public virtual DbSet<TbAnunciomodelo> Anunciomodelo { get; set; }
        public virtual DbSet<TbCategoria> Categoria { get; set; }
        public virtual DbSet<TbCompra> Compra { get; set; }
        public virtual DbSet<TbBEnvio> Envio { get; set; }
        public virtual DbSet<TbModelo> Modelo { get; set; }
        public virtual DbSet<TbPagamento> Pagamento { get; set; }
        public virtual DbSet<TbTroca> Troca { get; set; }
        public virtual DbSet<TbTrocaanuncio> Trocaanuncio { get; set; }
        public virtual DbSet<TbTrocamodelo> Trocamodelo { get; set; }
        public virtual DbSet<TbUsuario> Usuario { get; set; }
        public virtual DbSet<TbUsuariocategoria> Usuariocategoria { get; set; }
        public virtual DbSet<TbUsuariosubcategoria> Usuariosubcategoria { get; set; }

        //NÃO GEROU TBSUBCATEGORIA!!!!!

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=123456;database=bancocollector");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TbAnuncio>(entity =>
            {
                entity.HasKey(e => e.CodAnuncio);

                entity.ToTable("anuncio", "bancocollector");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Anuncio_Usuario1_idx");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

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
                    .HasConstraintName("fk_Anuncio_Usuario1");
            });

            modelBuilder.Entity<TbAnunciomodelo>(entity =>
            {
                entity.HasKey(e => new { e.CodAnuncio, e.CodModelo });

                entity.ToTable("anunciomodelo", "bancocollector");

                entity.HasIndex(e => e.CodAnuncio)
                    .HasName("fk_anuncio_has_modelo_anuncio1_idx");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_anuncio_has_modelo_modelo1_idx");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodAnuncioNavigation)
                    .WithMany(p => p.Anunciomodelo)
                    .HasForeignKey(d => d.CodAnuncio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_anuncio_has_modelo_anuncio1");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Anunciomodelo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_anuncio_has_modelo_modelo1");
            });

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasKey(e => e.CodCategoria);

                entity.ToTable("categoria", "bancocollector");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSubcategoria>(entity =>
            {
                entity.HasKey(e => e.CodCategoria);

                entity.ToTable("Subcategoria", "bancocollector");

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodCategoria)
                   .HasColumnName("codCategoria")
                   .HasColumnType("int(11)")
                   .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCompra>(entity =>
            {
                entity.HasKey(e => e.CodCompra);

                entity.ToTable("compra", "bancocollector");

                entity.HasIndex(e => e.CodEnvio)
                    .HasName("fk_Compra_Envio1_idx");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_Compra_Modelo1_idx");

                entity.HasIndex(e => e.CodPagamento)
                    .HasName("fk_Compra_Pagamento1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Compra_Usuario1_idx");

                entity.Property(e => e.CodCompra)
                    .HasColumnName("codCompra")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPagamento)
                    .HasColumnName("codPagamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
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
                    .HasConstraintName("fk_Compra_Modelo1");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Pagamento1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CodUsuario)
                    .HasConstraintName("fk_Compra_Usuario1");
            });

            modelBuilder.Entity<TbBEnvio>(entity =>
            {
                entity.HasKey(e => e.CodEnvio);

                entity.ToTable("envio", "bancocollector");

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

            modelBuilder.Entity<TbModelo>(entity =>
            {
                entity.HasKey(e => e.CodModelo);

                entity.ToTable("modelo", "bancocollector");

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

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Modelo)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Modelo_Usuario1");
            });

            modelBuilder.Entity<TbPagamento>(entity =>
            {
                entity.HasKey(e => e.CodPagamento);

                entity.ToTable("pagamento", "bancocollector");

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

            modelBuilder.Entity<TbTroca>(entity =>
            {
                entity.HasKey(e => new { e.CodTroca, e.CodUsuario });

                entity.ToTable("troca", "bancocollector");

                entity.HasIndex(e => e.CodEnvio)
                    .HasName("fk_Troca_Envio1_idx");

                entity.HasIndex(e => e.CodPagamento)
                    .HasName("fk_Troca_Pagamento1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Troca_Usuario1_idx");

                entity.Property(e => e.CodTroca)
                    .HasColumnName("codTroca")
                    .HasColumnType("int(11)");

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
                    .HasConstraintName("fk_Troca_Usuario1");
            });

            modelBuilder.Entity<TbTrocaanuncio>(entity =>
            {
                entity.HasKey(e => new { e.CodTroca, e.CodAnuncio });

                entity.ToTable("trocaanuncio", "bancocollector");

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

                entity.HasOne(d => d.CodAnuncioNavigation)
                    .WithMany(p => p.Trocaanuncio)
                    .HasForeignKey(d => d.CodAnuncio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Anuncio_Anuncio1");
            });

            modelBuilder.Entity<TbTrocamodelo>(entity =>
            {
                entity.HasKey(e => new { e.TrocaCodTroca, e.ModeloCodModelo });

                entity.ToTable("trocamodelo", "bancocollector");

                entity.HasIndex(e => e.ModeloCodModelo)
                    .HasName("fk_Troca_has_Modelo_Modelo1_idx");

                entity.HasIndex(e => e.TrocaCodTroca)
                    .HasName("fk_Troca_has_Modelo_Troca1_idx");

                entity.Property(e => e.TrocaCodTroca)
                    .HasColumnName("trocaCodTroca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModeloCodModelo)
                    .HasColumnName("modeloCodModelo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ModeloCodModeloNavigation)
                    .WithMany(p => p.Trocamodelo)
                    .HasForeignKey(d => d.ModeloCodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Modelo_Modelo1");
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario);

                entity.ToTable("usuario", "bancocollector");

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
                    .HasMaxLength(13)
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

            modelBuilder.Entity<TbUsuariocategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodCategoria });

                entity.ToTable("usuariocategoria", "bancocollector");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("fk_Usuario_has_Categoria_Categoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Usuario_has_Categoria_Usuario1_idx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");
//ele comentou aqui... 
                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.Usuariocategoria)
                    .HasForeignKey(d => d.CodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_has_Categoria_Categoria1");
//até aqui
                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Usuariocategoria)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_has_Categoria_Usuario1");
            });

            modelBuilder.Entity<TbUsuariosubcategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodSubcategoria });

                entity.ToTable("usuariosubcategoria", "bancocollector");

                entity.HasIndex(e => e.CodSubcategoria)
                    .HasName("fk_Usuario_has_SubCategoria_SubCategoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Usuario_has_SubCategoria_Usuario1_idx");

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
                    .HasConstraintName("fk_Usuario_has_SubCategoria_Usuario1");
            });
        }
    }
}
