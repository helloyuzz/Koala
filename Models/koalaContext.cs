using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Koala.Models
{
    public partial class koalaContext : DbContext
    {
        public koalaContext()
        {
        }

        public koalaContext(DbContextOptions<koalaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleRight> RoleRights { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserMapping> UserMappings { get; set; }
        public virtual DbSet<Version> Versions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=koala;uid=root;pwd=aa123456;sslmode=None;allowpublickeyretrieval=true", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.BackgroundUrl)
                    .HasMaxLength(60)
                    .HasColumnName("background_url");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("create_on");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(60)
                    .HasColumnName("group_id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.IsRoot).HasColumnName("is_root");

                entity.Property(e => e.LicenceCode)
                    .HasMaxLength(60)
                    .HasColumnName("licence_code");

                entity.Property(e => e.LicenceTo)
                    .HasColumnType("date")
                    .HasColumnName("licence_to");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(60)
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

                entity.Property(e => e.Pinyin)
                    .HasMaxLength(60)
                    .HasColumnName("pinyin");

                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasColumnName("position");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(60)
                    .HasColumnName("short_name");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .HasColumnName("status");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("update_on");

                entity.Property(e => e.VersionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("version_id");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(30)
                    .HasColumnName("area");

                entity.Property(e => e.AspPage)
                    .HasMaxLength(60)
                    .HasColumnName("asp_page");

                entity.Property(e => e.Class)
                    .HasMaxLength(60)
                    .HasColumnName("class");

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

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("modules");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateVersion)
                    .HasColumnType("int(11)")
                    .HasColumnName("create_version")
                    .HasComment("发布版本");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("模块名称");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status")
                    .HasComment("状态：启用，禁用");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("packages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .HasColumnName("code");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("date")
                    .HasColumnName("create_on");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(60)
                    .HasColumnName("short_name");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("date")
                    .HasColumnName("update_on");
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.ToTable("rights");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("date")
                    .HasColumnName("create_on");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("module_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.Permission)
                    .HasMaxLength(60)
                    .HasColumnName("permission")
                    .HasComment("权限，查看、增加、修改、删除=View,Add,Edit,Drop");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("date")
                    .HasColumnName("update_on");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("date")
                    .HasColumnName("create_on");

                entity.Property(e => e.HospitalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hospital_id")
                    .HasComment("院区id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("角色名称");

                entity.Property(e => e.SectionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("section_id")
                    .HasComment("科室id");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status")
                    .HasComment("状态：启用、禁用");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("date")
                    .HasColumnName("update_on");
            });

            modelBuilder.Entity<RoleRight>(entity =>
            {
                entity.ToTable("role_rights");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Create)
                    .HasColumnName("create")
                    .HasComment("新增");

                entity.Property(e => e.Drop)
                    .HasColumnName("drop")
                    .HasComment("删除");

                entity.Property(e => e.Edit)
                    .HasColumnName("edit")
                    .HasComment("编辑");

                entity.Property(e => e.Export)
                    .HasColumnName("export")
                    .HasComment("导出");

                entity.Property(e => e.Print)
                    .HasColumnName("print")
                    .HasComment("打印");

                entity.Property(e => e.RightId)
                    .HasColumnType("int(11)")
                    .HasColumnName("right_id");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("role_id");

                entity.Property(e => e.View)
                    .HasColumnName("view")
                    .HasComment("查看");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("sections");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("date")
                    .HasColumnName("create_on");

                entity.Property(e => e.HospitalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hospital_id");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("manager_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.Pinyin)
                    .HasMaxLength(60)
                    .HasColumnName("pinyin");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(60)
                    .HasColumnName("short_name");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("date")
                    .HasColumnName("update_on");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasComment("用户");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("create_on");

                entity.Property(e => e.HashedPassword)
                    .HasMaxLength(60)
                    .HasColumnName("hashed_password")
                    .HasComment("密码");

                entity.Property(e => e.HospitalId)
                    .HasColumnType("int(8)")
                    .HasColumnName("hospital_id");

                entity.Property(e => e.IsAdmin).HasColumnName("is_admin");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.LastLoginOn)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_on");

                entity.Property(e => e.Login)
                    .HasMaxLength(60)
                    .HasColumnName("login")
                    .HasComment("帐号");

                entity.Property(e => e.MustChangePasswd).HasColumnName("must_change_passwd");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("姓名");

                entity.Property(e => e.Pinyin)
                    .HasMaxLength(60)
                    .HasColumnName("pinyin");

                entity.Property(e => e.Salt)
                    .HasMaxLength(60)
                    .HasColumnName("salt");

                entity.Property(e => e.SectionId)
                    .HasColumnType("int(8)")
                    .HasColumnName("section_id");

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

            modelBuilder.Entity<UserMapping>(entity =>
            {
                entity.ToTable("user_mappings");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.TargetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type")
                    .HasComment("关联类型，院区、科室、角色、外来器械厂商");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.ToTable("versions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.PublishOn)
                    .HasColumnType("date")
                    .HasColumnName("publish_on")
                    .HasComment("发布日期");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateLog)
                    .HasColumnType("text")
                    .HasColumnName("update_log")
                    .HasComment("版本说明");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("date")
                    .HasColumnName("update_on")
                    .HasComment("升级日期");

                entity.Property(e => e.VersionLog)
                    .HasColumnType("text")
                    .HasColumnName("version_log");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
