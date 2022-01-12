using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Koala.Models_temp
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

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Clean> Cleans { get; set; }
        public virtual DbSet<CustomFlow> CustomFlows { get; set; }
        public virtual DbSet<ExternalRecyle> ExternalRecyles { get; set; }
        public virtual DbSet<Flow> Flows { get; set; }
        public virtual DbSet<FlowStatus> FlowStatuses { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Recyle> Recyles { get; set; }
        public virtual DbSet<RecyleInstrument> RecyleInstruments { get; set; }
        public virtual DbSet<RecylePackage> RecylePackages { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleRight> RoleRights { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRelation> UserRelations { get; set; }
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

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("attachments");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AttachmentType)
                    .HasColumnType("int(6)")
                    .HasColumnName("attachment_type");

                entity.Property(e => e.DiskFile)
                    .HasMaxLength(60)
                    .HasColumnName("disk_file");

                entity.Property(e => e.DiskPath)
                    .HasMaxLength(60)
                    .HasColumnName("disk_path");

                entity.Property(e => e.DownloadCount)
                    .HasColumnType("int(6)")
                    .HasColumnName("download_count");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(60)
                    .HasColumnName("file_ext");

                entity.Property(e => e.FileLength)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("file_length");

                entity.Property(e => e.FileName)
                    .HasMaxLength(60)
                    .HasColumnName("file_name");

                entity.Property(e => e.Hash)
                    .HasMaxLength(60)
                    .HasColumnName("hash");

                entity.Property(e => e.ObjId)
                    .HasColumnType("int(6)")
                    .HasColumnName("obj_id");

                entity.Property(e => e.Position)
                    .HasColumnType("int(6)")
                    .HasColumnName("position");

                entity.Property(e => e.UploadBy)
                    .HasColumnType("int(6)")
                    .HasColumnName("upload_by");

                entity.Property(e => e.UploadOn)
                    .HasColumnType("datetime")
                    .HasColumnName("upload_on");

                entity.Property(e => e.ViewCount)
                    .HasColumnType("int(6)")
                    .HasColumnName("view_count");
            });

            modelBuilder.Entity<Clean>(entity =>
            {
                entity.ToTable("cleans");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("int(11)")
                    .HasColumnName("create_on");

                entity.Property(e => e.FlowId)
                    .HasColumnType("int(11)")
                    .HasColumnName("flow_id");
            });

            modelBuilder.Entity<CustomFlow>(entity =>
            {
                entity.ToTable("custom_flows");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Clean)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("clean")
                    .HasComment("清洗");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("自定义流程名称");

                entity.Property(e => e.Recyle)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("recyle")
                    .HasComment("回收");
            });

            modelBuilder.Entity<ExternalRecyle>(entity =>
            {
                entity.ToTable("external_recyles");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id");

                entity.Property(e => e.DespatcherId)
                    .HasColumnType("int(6)")
                    .HasColumnName("despatcher_id")
                    .HasComment("操作人员");

                entity.Property(e => e.InstrumentCount)
                    .HasColumnType("int(6)")
                    .HasColumnName("instrument_count");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnType("int(6)")
                    .HasColumnName("manufacturer_id")
                    .HasComment("厂商名称");

                entity.Property(e => e.OperationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("operation_date");

                entity.Property(e => e.PackageCount)
                    .HasColumnType("int(6)")
                    .HasColumnName("package_count");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(60)
                    .HasColumnName("patient_name");

                entity.Property(e => e.RecyleBy)
                    .HasColumnType("int(6)")
                    .HasColumnName("recyle_by");

                entity.Property(e => e.RecyleOn)
                    .HasColumnType("datetime")
                    .HasColumnName("recyle_on")
                    .HasComment("申请日期");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Flow>(entity =>
            {
                entity.ToTable("flows");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CloseOn)
                    .HasColumnType("datetime")
                    .HasColumnName("close_on");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("create_on");

                entity.Property(e => e.CustomFlowId)
                    .HasColumnType("int(60)")
                    .HasColumnName("custom_flow_id")
                    .HasComment("自定义流程编号");

                entity.Property(e => e.PrevId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prev_id");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_id");
            });

            modelBuilder.Entity<FlowStatus>(entity =>
            {
                entity.ToTable("flow_status");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("状态名称");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("hospitals");

                entity.HasComment("医院");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
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

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.ToTable("instruments");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Graphy)
                    .HasMaxLength(60)
                    .HasColumnName("graphy");

                entity.Property(e => e.InstrumentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("instrument_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.PackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("package_id");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
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

                entity.Property(e => e.Hidden)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("hidden");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(6)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Position)
                    .HasColumnType("int(6)")
                    .HasColumnName("position");

                entity.Property(e => e.Unread)
                    .HasColumnType("int(6)")
                    .HasColumnName("unread");
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

                entity.Property(e => e.Graphy)
                    .HasMaxLength(60)
                    .HasColumnName("graphy")
                    .HasComment("修改痕迹");

                entity.Property(e => e.IsDelete).HasColumnName("is_delete");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.Property(e => e.PackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("package_id")
                    .HasComment("id允许相同，graphy=null表示最新记录，graphy!=null标识历史修改记录");

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

            modelBuilder.Entity<Recyle>(entity =>
            {
                entity.ToTable("recyles");

                entity.HasIndex(e => e.RecyleBy, "fk_recyle_by");

                entity.HasIndex(e => e.UserId, "fk_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id");

                entity.Property(e => e.RecyleBy)
                    .HasColumnType("int(6)")
                    .HasColumnName("recyle_by")
                    .HasComment("回收人");

                entity.Property(e => e.RecyleOn)
                    .HasColumnType("datetime")
                    .HasColumnName("recyle_on")
                    .HasComment("回收日期");

                entity.Property(e => e.SectionId)
                    .HasColumnType("int(6)")
                    .HasColumnName("section_id")
                    .HasComment("移交科室");

                entity.Property(e => e.SeqNo)
                    .HasMaxLength(60)
                    .HasColumnName("seq_no")
                    .HasComment("流水号");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .HasColumnName("status");

                entity.Property(e => e.Summary)
                    .HasMaxLength(60)
                    .HasColumnName("summary")
                    .HasComment("摘要");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(6)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<RecyleInstrument>(entity =>
            {
                entity.ToTable("recyle_instruments");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.PackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("package_id");
            });

            modelBuilder.Entity<RecylePackage>(entity =>
            {
                entity.ToTable("recyle_packages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Graphy)
                    .HasMaxLength(60)
                    .HasColumnName("graphy");

                entity.Property(e => e.PackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("package_id");

                entity.Property(e => e.RecyleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("recyle_id");
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

                entity.Property(e => e.Avator)
                    .HasMaxLength(60)
                    .HasColumnName("avator");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("create_on")
                    .HasComment("创建于");

                entity.Property(e => e.HashedPassword)
                    .HasMaxLength(60)
                    .HasColumnName("hashed_password")
                    .HasComment("密码");

                entity.Property(e => e.HospitalId)
                    .HasColumnType("int(8)")
                    .HasColumnName("hospital_id")
                    .HasComment("院区");

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("is_admin")
                    .HasComment("管理员");

                entity.Property(e => e.IsDelete)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_delete")
                    .HasComment("已禁用");

                entity.Property(e => e.IsTemp)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_temp")
                    .HasComment("是否临时工");

                entity.Property(e => e.LastLoginOn)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_on")
                    .HasComment("最近登录");

                entity.Property(e => e.Login)
                    .HasMaxLength(60)
                    .HasColumnName("login")
                    .HasComment("登录帐号");

                entity.Property(e => e.MustChangePasswd)
                    .HasColumnName("must_change_passwd")
                    .HasComment("必须修改密码");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name")
                    .HasComment("姓名");

                entity.Property(e => e.Pinyin)
                    .HasMaxLength(60)
                    .HasColumnName("pinyin")
                    .HasComment("拼音");

                entity.Property(e => e.Salt)
                    .HasMaxLength(60)
                    .HasColumnName("salt");

                entity.Property(e => e.SectionId)
                    .HasColumnType("int(8)")
                    .HasColumnName("section_id")
                    .HasComment("科室");

                entity.Property(e => e.Status)
                    .HasColumnType("int(6)")
                    .HasColumnName("status")
                    .HasComment("状态");

                entity.Property(e => e.Type)
                    .HasMaxLength(60)
                    .HasColumnName("type")
                    .HasComment("类型");

                entity.Property(e => e.UpdateOn)
                    .HasColumnType("datetime")
                    .HasColumnName("update_on")
                    .HasComment("更新于");
            });

            modelBuilder.Entity<UserRelation>(entity =>
            {
                entity.ToTable("user_relations");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ObjId)
                    .HasColumnType("int(11)")
                    .HasColumnName("obj_id");

                entity.Property(e => e.RelationType)
                    .HasMaxLength(255)
                    .HasColumnName("relation_type")
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
