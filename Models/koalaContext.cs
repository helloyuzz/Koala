using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Koala.Models {
    public partial class koalaContext : DbContext {
        public koalaContext() {
        }

        public koalaContext(DbContextOptions<koalaContext> options)
            : base(options) {
        }

        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=koala;uid=root;pwd=aa123456;sslmode=None;allowpublickeyretrieval=true", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("hospitals");

                entity.HasComment("医院");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("create_on");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(60)
                    .HasColumnName("group_id");

                entity.Property(e => e.LicenceCode)
                    .HasMaxLength(60)
                    .HasColumnName("licence_code");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(255)
                    .HasColumnName("logo_url");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("manager_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasColumnName("position");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(60)
                    .HasColumnName("short_name");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AspPage)
                    .HasMaxLength(60)
                    .HasColumnName("asp_page");

                entity.Property(e => e.Class)
                    .HasMaxLength(60)
                    .HasColumnName("class");

                entity.Property(e => e.Area)
                    .HasMaxLength(60)
                    .HasColumnName("area");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasColumnName("position");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasComment("用户");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(60)
                    .HasColumnName("login")
                    .HasComment("帐号");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("create_on");

                entity.Property(e => e.HashedPassword)
                    .HasMaxLength(60)
                    .HasColumnName("hashed_password")
                    .HasComment("密码");

                entity.Property(e => e.HospitalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hospital_id");

                entity.Property(e => e.IsAdmin)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_admin");

                entity.Property(e => e.LastLoginOn)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_on");

                entity.Property(e => e.MustChangePasswd)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("must_change_passwd");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("姓名");

                entity.Property(e => e.Salt)
                    .HasMaxLength(60)
                    .HasColumnName("salt");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(60)
                    .HasColumnName("type");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("update_on");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}