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

        public virtual DbSet<Anunciomodelo> Anunciomodelo { get; set; }
        public virtual DbSet<Negociacaoanuncio> Negociacaoanuncio { get; set; }
        public virtual DbSet<Negociacaomodelo> Negociacaomodelo { get; set; }
        public virtual DbSet<Negociacaopagamento> Negociacaopagamento { get; set; }
        public virtual DbSet<Tbanuncio> Tbanuncio { get; set; }
        public virtual DbSet<Tbcategoria> Tbcategoria { get; set; }
        public virtual DbSet<Tbenvio> Tbenvio { get; set; }
        public virtual DbSet<Tbmodelo> Tbmodelo { get; set; }
        public virtual DbSet<Tbnegociacao> Tbnegociacao { get; set; }
        public virtual DbSet<Tbpagamento> Tbpagamento { get; set; }
        public virtual DbSet<Tbsubcategoria> Tbsubcategoria { get; set; }
        public virtual DbSet<Tbusuario> Tbusuario { get; set; }

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

            modelBuilder.Entity<Anunciomodelo>(entity =>
            {
                entity.HasKey(e => new { e.CodAnuncio, e.CodModelo });

                entity.ToTable("anunciomodelo", "bancocollector");

                entity.HasIndex(e => e.CodAnuncio)
                    .HasName("fk_TbAnuncio_has_TbModelo_TbAnuncio1_idx");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_TbAnuncio_has_TbModelo_TbModelo1_idx");

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
                    .HasConstraintName("fk_TbAnuncio_has_TbModelo_TbAnuncio1");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Anunciomodelo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbAnuncio_has_TbModelo_TbModelo1");
            });

            modelBuilder.Entity<Negociacaoanuncio>(entity =>
            {
                entity.HasKey(e => new { e.CodNegociacao, e.CodAnuncio });

                entity.ToTable("negociacaoanuncio", "bancocollector");

                entity.HasIndex(e => e.CodAnuncio)
                    .HasName("fk_TbNegociacao_has_TbAnuncio_TbAnuncio1_idx");

                entity.HasIndex(e => e.CodNegociacao)
                    .HasName("fk_TbNegociacao_has_TbAnuncio_TbNegociacao1_idx");

                entity.Property(e => e.CodNegociacao)
                    .HasColumnName("codNegociacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodAnuncio)
                    .HasColumnName("codAnuncio")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodAnuncioNavigation)
                    .WithMany(p => p.Negociacaoanuncio)
                    .HasForeignKey(d => d.CodAnuncio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_has_TbAnuncio_TbAnuncio1");

                entity.HasOne(d => d.CodNegociacaoNavigation)
                    .WithMany(p => p.Negociacaoanuncio)
                    .HasForeignKey(d => d.CodNegociacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_has_TbAnuncio_TbNegociacao1");
            });

            modelBuilder.Entity<Negociacaomodelo>(entity =>
            {
                entity.HasKey(e => new { e.CodNegociacao, e.CodModelo });

                entity.ToTable("negociacaomodelo", "bancocollector");

                entity.HasIndex(e => e.CodModelo)
                    .HasName("fk_TbNegociacao_has_TbModelo_TbModelo1_idx");

                entity.HasIndex(e => e.CodNegociacao)
                    .HasName("fk_TbNegociacao_has_TbModelo_TbNegociacao1_idx");

                entity.Property(e => e.CodNegociacao)
                    .HasColumnName("codNegociacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodModeloNavigation)
                    .WithMany(p => p.Negociacaomodelo)
                    .HasForeignKey(d => d.CodModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_has_TbModelo_TbModelo1");

                entity.HasOne(d => d.CodNegociacaoNavigation)
                    .WithMany(p => p.Negociacaomodelo)
                    .HasForeignKey(d => d.CodNegociacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_has_TbModelo_TbNegociacao1");
            });

            modelBuilder.Entity<Negociacaopagamento>(entity =>
            {
                entity.HasKey(e => new { e.CodNegociacao, e.CodPagamento });

                entity.ToTable("negociacaopagamento", "bancocollector");

                entity.HasIndex(e => e.CodNegociacao)
                    .HasName("fk_TbNegociacao_has_TbPagamento_TbNegociacao1_idx");

                entity.HasIndex(e => e.CodPagamento)
                    .HasName("fk_TbNegociacao_has_TbPagamento_TbPagamento1_idx");

                entity.Property(e => e.CodNegociacao)
                    .HasColumnName("codNegociacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodPagamento)
                    .HasColumnName("codPagamento")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodNegociacaoNavigation)
                    .WithMany(p => p.Negociacaopagamento)
                    .HasForeignKey(d => d.CodNegociacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_has_TbPagamento_TbNegociacao1");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Negociacaopagamento)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_has_TbPagamento_TbPagamento1");
            });

            modelBuilder.Entity<Tbanuncio>(entity =>
            {
                entity.HasKey(e => e.CodAnuncio);

                entity.ToTable("tbanuncio", "bancocollector");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_TbAnuncio_TbUsuario1_idx");

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

                entity.Property(e => e.QuantAnunciada)
                    .HasColumnName("quantAnunciada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuantDisponivel)
                    .HasColumnName("quantDisponivel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('Ativo','Inativo')");

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
                    .HasConstraintName("fk_TbAnuncio_TbUsuario1");
            });

            modelBuilder.Entity<Tbcategoria>(entity =>
            {
                entity.HasKey(e => e.CodCategoria);

                entity.ToTable("tbcategoria", "bancocollector");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbenvio>(entity =>
            {
                entity.HasKey(e => e.CodEnvio);

                entity.ToTable("tbenvio", "bancocollector");

                entity.HasIndex(e => e.CodNegociacao)
                    .HasName("fk_TbEnvio_TbNegociacao_idx");

                entity.Property(e => e.CodEnvio)
                    .HasColumnName("codEnvio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasColumnName("bairro")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodNegociacao)
                    .HasColumnName("codNegociacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Destinatario)
                    .IsRequired()
                    .HasColumnName("destinatario")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasColumnName("endereco")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Remetente)
                    .IsRequired()
                    .HasColumnName("remetente")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('PAC','SEDEX','PESSOALMENTE')");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.CodNegociacaoNavigation)
                    .WithMany(p => p.Tbenvio)
                    .HasForeignKey(d => d.CodNegociacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbEnvio_TbNegociacao");
            });

            modelBuilder.Entity<Tbmodelo>(entity =>
            {
                entity.HasKey(e => e.CodModelo);

                entity.ToTable("tbmodelo", "bancocollector");

                entity.HasIndex(e => e.CodSubcategoria)
                    .HasName("fk_TbModelo_TbSubcategoria1_idx");

                entity.HasIndex(e => e.TbUsuarioCodUsuario)
                    .HasName("fk_TbModelo_TbUsuario1_idx");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("codModelo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Autor)
                    .HasColumnName("autor")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Colecao)
                    .HasColumnName("colecao")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Desenhista)
                    .HasColumnName("desenhista")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Edicao)
                    .HasColumnName("edicao")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn)
                    .HasColumnName("isbn")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.QuantTiragem)
                    .HasColumnName("quantTiragem")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Roteirista)
                    .HasColumnName("roteirista")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TbUsuarioCodUsuario)
                    .HasColumnName("TbUsuario_codUsuario")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodSubcategoriaNavigation)
                    .WithMany(p => p.Tbmodelo)
                    .HasForeignKey(d => d.CodSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbModelo_TbSubcategoria1");

                entity.HasOne(d => d.TbUsuarioCodUsuarioNavigation)
                    .WithMany(p => p.Tbmodelo)
                    .HasForeignKey(d => d.TbUsuarioCodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbModelo_TbUsuario1");
            });

            modelBuilder.Entity<Tbnegociacao>(entity =>
            {
                entity.HasKey(e => e.CodNegociacao);

                entity.ToTable("tbnegociacao", "bancocollector");

                entity.HasIndex(e => e.CodUsuario)
                    .HasName("fk_TbNegociacao_TbUsuario1_idx");

                entity.Property(e => e.CodNegociacao)
                    .HasColumnName("codNegociacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('Aberto','Aguardando contraproposta','Fechado')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('venda','troca','vendaTroca')");

                entity.Property(e => e.ValorProposto).HasColumnName("valorProposto");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.Tbnegociacao)
                    .HasForeignKey(d => d.CodUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbNegociacao_TbUsuario1");
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
                    .HasColumnType("enum('Boleto','Cartao')");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<Tbsubcategoria>(entity =>
            {
                entity.HasKey(e => e.CodSubcategoria);

                entity.ToTable("tbsubcategoria", "bancocollector");

                entity.HasIndex(e => e.CodCategoria)
                    .HasName("fk_TbSubcategoria_TbCategoria1_idx");

                entity.Property(e => e.CodSubcategoria)
                    .HasColumnName("codSubcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodCategoria)
                    .HasColumnName("codCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCategoriaNavigation)
                    .WithMany(p => p.Tbsubcategoria)
                    .HasForeignKey(d => d.CodCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TbSubcategoria_TbCategoria1");
            });

            modelBuilder.Entity<Tbusuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario);

                entity.ToTable("tbusuario", "bancocollector");

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("codUsuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Administrador)
                    .IsRequired()
                    .HasColumnName("administrador")
                    .HasColumnType("enum('SIM','NAO')");

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
        }
    }
}
