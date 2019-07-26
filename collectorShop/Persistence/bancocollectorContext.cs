using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public virtual DbSet<TbCategoria> TbCategoria { get; set; }
        public virtual DbSet<Tbanuncio> Tbanuncio { get; set; }
        public virtual DbSet<Tbanunciomodelo> Tbanunciomodelo { get; set; }
        public virtual DbSet<Tbcompra> Tbcompra { get; set; }
        public virtual DbSet<Tbenvio> Tbenvio { get; set; }
        public virtual DbSet<Tbmodelo> Tbmodelo { get; set; }
        public virtual DbSet<Tbpagamento> Tbpagamento { get; set; }
        public virtual DbSet<Tbsubcategoria> Tbsubcategoria { get; set; }
        public virtual DbSet<Tbtroca> Tbtroca { get; set; }
        public virtual DbSet<Tbtrocaanuncio> Tbtrocaanuncio { get; set; }
        public virtual DbSet<Tbtrocamodelo> Tbtrocamodelo { get; set; }
        public virtual DbSet<Tbusuario> Tbusuario { get; set; }
        public virtual DbSet<Tbusuariocategoria> Tbusuariocategoria { get; set; }
        public virtual DbSet<Tbusuariosubcategoria> Tbusuariosubcategoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=bancocollector");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasKey(e => e.CodCategoria);

                entity.ToTable("tb_categoria", "bancocollector");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbanuncio>(entity =>
            {
                entity.HasKey(e => e.CodAnuncio);

                entity.ToTable("tbanuncio", "bancocollector");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Anuncio_Usuario1_idx");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .IsRequired()
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
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbanuncio)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Anuncio_Usuario1");
            });

            modelBuilder.Entity<Tbanunciomodelo>(entity =>
            {
                entity.HasKey(e => new { e.CodAnuncio, e.CodModelo });

                entity.ToTable("tbanunciomodelo", "bancocollector");

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
                    .WithMany(p => p.Tbanunciomodelo)
                    .HasForeignKey(d => d.CodAnuncio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_anuncio_has_modelo_anuncio1");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Tbanunciomodelo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_anuncio_has_modelo_modelo1");
            });

            modelBuilder.Entity<Tbcompra>(entity =>
            {
                entity.HasKey(e => e.CodCompra);

                entity.ToTable("tbcompra", "bancocollector");

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

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.ValorTotal).HasColumnName("valorTotal");

                entity.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");

                entity.HasOne(d => d.CodEnvioNavigation)
                    .WithMany(p => p.Tbcompra)
                    .HasForeignKey(d => d.CodEnvio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Envio1");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Tbcompra)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Modelo1");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Tbcompra)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Pagamento1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbcompra)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Usuario1");
            });

            modelBuilder.Entity<Tbenvio>(entity =>
            {
                entity.HasKey(e => e.CodEnvio);

                entity.ToTable("tbenvio", "bancocollector");

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Preco).HasColumnName("preco");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbmodelo>(entity =>
            {
                entity.HasKey(e => e.CodModelo);

                entity.ToTable("tbmodelo", "bancocollector");

                entity.HasIndex(e => e.CodSubcategoria)
                    .HasName("fk_Tbmodelo_TbSubcategoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Modelo_Usuario1_idx");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

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

                entity.HasOne(d => d.CodSubcategoriaNavigation)
                    .WithMany(p => p.Tbmodelo)
                    .HasForeignKey(d => d.CodSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tbmodelo_TbSubcategoria1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbmodelo)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Modelo_Usuario1");
            });

            modelBuilder.Entity<Tbpagamento>(entity =>
            {
                entity.HasKey(e => e.CodPagamento);

                entity.ToTable("tbpagamento", "bancocollector");

                entity.Property(e => e.CodPagamento)
                    .HasColumnName("codPagamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Opcao)
                    .IsRequired()
                    .HasColumnName("opcao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<Tbsubcategoria>(entity =>
            {
                entity.HasKey(e => e.CodSubcategoria);

                entity.ToTable("tbsubcategoria", "bancocollector");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("fk_TbSubcategoria_Tb_categoria1_idx");

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
                    .WithMany(p => p.Tbsubcategoria)
                    .HasForeignKey(d => d.CodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbSubcategoria_Tb_categoria1");
            });

            modelBuilder.Entity<Tbtroca>(entity =>
            {
                entity.HasKey(e => e.CodTroca);

                entity.ToTable("tbtroca", "bancocollector");

                entity.HasIndex(e => e.CodEnvio)
                    .HasName("fk_Troca_Envio1_idx");

                entity.HasIndex(e => e.CodPagamento)
                    .HasName("fk_Troca_Pagamento1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Troca_Usuario1_idx");

                entity.Property(e => e.CodTroca)
                    .HasColumnName("codTroca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
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

                entity.Property(e => e.Quantidade)
                    .HasColumnName("quantidade")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodEnvioNavigation)
                    .WithMany(p => p.Tbtroca)
                    .HasForeignKey(d => d.CodEnvio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_Envio1");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Tbtroca)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_Pagamento1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbtroca)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_Usuario1");
            });

            modelBuilder.Entity<Tbtrocaanuncio>(entity =>
            {
                entity.HasKey(e => new { e.CodTroca, e.CodAnuncio });

                entity.ToTable("tbtrocaanuncio", "bancocollector");

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
                    .WithMany(p => p.Tbtrocaanuncio)
                    .HasForeignKey(d => d.CodAnuncio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Anuncio_Anuncio1");

                entity.HasOne(d => d.CodTrocaNavigation)
                    .WithMany(p => p.Tbtrocaanuncio)
                    .HasForeignKey(d => d.CodTroca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Anuncio_Troca1");
            });

            modelBuilder.Entity<Tbtrocamodelo>(entity =>
            {
                entity.HasKey(e => new { e.TrocaCodTroca, e.ModeloCodModelo });

                entity.ToTable("tbtrocamodelo", "bancocollector");

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
                    .WithMany(p => p.Tbtrocamodelo)
                    .HasForeignKey(d => d.ModeloCodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Modelo_Modelo1");

                entity.HasOne(d => d.TrocaCodTrocaNavigation)
                    .WithMany(p => p.Tbtrocamodelo)
                    .HasForeignKey(d => d.TrocaCodTroca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Troca_has_Modelo_Troca1");
            });

            modelBuilder.Entity<Tbusuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario);

                entity.ToTable("tbusuario", "bancocollector");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

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

            modelBuilder.Entity<Tbusuariocategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodCategoria });

                entity.ToTable("tbusuariocategoria", "bancocollector");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("fk_TbusuarioCategoria_Tb_categoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Usuario_has_Categoria_Usuario1_idx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.Tbusuariocategoria)
                    .HasForeignKey(d => d.CodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbusuarioCategoria_Tb_categoria1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbusuariocategoria)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_has_Categoria_Usuario1");
            });

            modelBuilder.Entity<Tbusuariosubcategoria>(entity =>
            {
                entity.HasKey(e => new { e.CodUsuario, e.CodSubcategoria });

                entity.ToTable("tbusuariosubcategoria", "bancocollector");

                entity.HasIndex(e => e.CodSubcategoria)
                    .HasName("fk_TbusuarioSubCategoria_TbSubcategoria1_idx");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_Usuario_has_SubCategoria_Usuario1_idx");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodSubcategoriaNavigation)
                    .WithMany(p => p.Tbusuariosubcategoria)
                    .HasForeignKey(d => d.CodSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbusuarioSubCategoria_TbSubcategoria1");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbusuariosubcategoria)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Usuario_has_SubCategoria_Usuario1");
            });
        }
    }
}
