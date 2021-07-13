using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DTM_EXTENDEDContext : DbContext
    {
        public DTM_EXTENDEDContext()
        {
        }

        public DTM_EXTENDEDContext(DbContextOptions<DTM_EXTENDEDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DtmAction> DtmActions { get; set; }
        public virtual DbSet<DtmApplication> DtmApplications { get; set; }
        public virtual DbSet<DtmApplicationXmlObject> DtmApplicationXmlObjects { get; set; }
        public virtual DbSet<DtmDatabase> DtmDatabases { get; set; }
        public virtual DbSet<DtmDatabaseType> DtmDatabaseTypes { get; set; }
        public virtual DbSet<DtmField> DtmFields { get; set; }
        public virtual DbSet<DtmFieldType> DtmFieldTypes { get; set; }
        public virtual DbSet<DtmFilter> DtmFilters { get; set; }
        public virtual DbSet<DtmFilterGroup> DtmFilterGroups { get; set; }
        public virtual DbSet<DtmFilterParameter> DtmFilterParameters { get; set; }
        public virtual DbSet<DtmFkValue> DtmFkValues { get; set; }
        public virtual DbSet<DtmFkfield> DtmFkfields { get; set; }
        public virtual DbSet<DtmHtmlTable> DtmHtmlTables { get; set; }
        public virtual DbSet<DtmHtmlTableCell> DtmHtmlTableCells { get; set; }
        public virtual DbSet<DtmHtmlTableRow> DtmHtmlTableRows { get; set; }
        public virtual DbSet<DtmOperator> DtmOperators { get; set; }
        public virtual DbSet<DtmParameter> DtmParameters { get; set; }
        public virtual DbSet<DtmParameterType> DtmParameterTypes { get; set; }
        public virtual DbSet<DtmSite> DtmSites { get; set; }
        public virtual DbSet<DtmTable> DtmTables { get; set; }
        public virtual DbSet<DtmTablePermission> DtmTablePermissions { get; set; }
        public virtual DbSet<DtmUpfield> DtmUpfields { get; set; }
        public virtual DbSet<DtmUploadType> DtmUploadTypes { get; set; }
        public virtual DbSet<DtmUser> DtmUsers { get; set; }
        public virtual DbSet<DtmUserGroup> DtmUserGroups { get; set; }
        public virtual DbSet<DtmUserGroupsUser> DtmUserGroupsUsers { get; set; }
        public virtual DbSet<DtmXmlObject> DtmXmlObjects { get; set; }
        public virtual DbSet<DtmXmlObjectParameter> DtmXmlObjectParameters { get; set; }
        public virtual DbSet<DtmtestFkTable> DtmtestFkTables { get; set; }
        public virtual DbSet<DtmtestTable> DtmtestTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=DTM_EXTENDED;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DtmAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("DTM_Actions");

                entity.Property(e => e.ActionId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");
            });

            modelBuilder.Entity<DtmApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("DTM_Applications");

                entity.Property(e => e.ApplicationId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApplicationCaption)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.ApplicationSiteId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmApplicationXmlObject>(entity =>
            {
                entity.HasKey(e => e.ApplicationXmlObjectsId);

                entity.ToTable("DTM_ApplicationXmlObjects");

                entity.Property(e => e.ApplicationXmlObjectsId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApplicationXmlObjectsApplicationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApplicationXmlObjectsHtmlTableCellId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApplicationXmlObjectsXmlObjectId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmDatabase>(entity =>
            {
                entity.HasKey(e => e.DatabaseId);

                entity.ToTable("DTM_Databases");

                entity.Property(e => e.DatabaseId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatabaseApplicationString)
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.DatabaseConnString)
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.DatabaseTypeId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmDatabaseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTM_DatabaseTypes");

                entity.Property(e => e.DatabaseTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DatabaseTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DtmField>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("DTM_Fields");

                entity.Property(e => e.FieldId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FieldAutoIncrementSeed).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldAutoIncrementStep).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldCaption)
                    .IsRequired()
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.FieldDataTypeString)
                    .HasMaxLength(50)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.FieldFkfieldId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FieldFKFieldId");

                entity.Property(e => e.FieldHeight).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldIsPk).HasColumnName("FieldIsPK");

                entity.Property(e => e.FieldMaxChars).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.FieldOrder).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldParamValue)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.FieldTableId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldTypeId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldUpfieldId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FieldUPFieldId");

                entity.Property(e => e.FieldUrlLink)
                    .HasMaxLength(4000)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.FieldViewDescriptionChars).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FieldWidth).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmFieldType>(entity =>
            {
                entity.HasKey(e => e.FieldTypeId);

                entity.ToTable("DTM_FieldTypes");

                entity.Property(e => e.FieldTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FieldTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTM_Filters");

                entity.Property(e => e.FilterCustomSelect)
                    .HasMaxLength(4000)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.FilterDefaultValue)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.FilterFieldId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FilterFieldOperatorId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FilterId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FilterName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.FilterOperatorId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmFilterGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTM_FilterGroups");

                entity.Property(e => e.FilterGroupFilterId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FilterGroupFilterOperatorId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FilterGroupId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FilterGroupName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.FilterGroupOperatorId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmFilterParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DTM_FilterParameters");

                entity.Property(e => e.FilterParametersFilterId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FilterParametersId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FilterParametersParameterId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmFkValue>(entity =>
            {
                entity.HasKey(e => e.FkValueId);

                entity.ToTable("DTM_FkValues");

                entity.Property(e => e.FkValueId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FkValueFieldId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FkValueFkfieldId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FkValueFKFieldId");

                entity.Property(e => e.FkvalueDoNotDisplay).HasColumnName("FKValueDoNotDisplay");

                entity.Property(e => e.FkvalueOrder)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FKValueOrder");

                entity.Property(e => e.FkvalueSeparator)
                    .HasMaxLength(50)
                    .HasColumnName("FKValueSeparator")
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmFkfield>(entity =>
            {
                entity.HasKey(e => e.FkfieldId);

                entity.ToTable("DTM_FKFields");

                entity.Property(e => e.FkfieldId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FKFieldId");

                entity.Property(e => e.FkfieldKeyFieldId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FKFieldKeyFieldId");

                entity.Property(e => e.FkfieldTableId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FKFieldTableId");
            });

            modelBuilder.Entity<DtmHtmlTable>(entity =>
            {
                entity.HasKey(e => e.HtmlTableId);

                entity.ToTable("DTM_HtmlTables");

                entity.Property(e => e.HtmlTableId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HtmlTableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.HtmlTablePropertiesString)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmHtmlTableCell>(entity =>
            {
                entity.HasKey(e => e.HtmlTableCellId);

                entity.ToTable("DTM_HtmlTableCells");

                entity.Property(e => e.HtmlTableCellId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HtmlTableCellHtmlTableRowId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HtmlTableCellPropertiesString)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmHtmlTableRow>(entity =>
            {
                entity.HasKey(e => e.HtmlTableRowId);

                entity.ToTable("DTM_HtmlTableRows");

                entity.Property(e => e.HtmlTableRowId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HtmlTableRowHtmlTableId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HtmlTableRowPropertiesString)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmOperator>(entity =>
            {
                entity.HasKey(e => e.OperatorId);

                entity.ToTable("DTM_Operators");

                entity.Property(e => e.OperatorId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.OperatorValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");
            });

            modelBuilder.Entity<DtmParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterId);

                entity.ToTable("DTM_Parameters");

                entity.Property(e => e.ParameterId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ParameterDefaultValue).HasColumnType("sql_variant");

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.ParameterParameterTypeId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ParameterSiteId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmParameterType>(entity =>
            {
                entity.HasKey(e => e.ParameterTypeId);

                entity.ToTable("DTM_ParameterTypes");

                entity.Property(e => e.ParameterTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ParameterTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmSite>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("DTM_Sites");

                entity.Property(e => e.SiteId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SiteAppLinkAndroid).HasMaxLength(1000);

                entity.Property(e => e.SiteAppLinkIos).HasMaxLength(1000);

                entity.Property(e => e.SiteAppStoreLink).HasMaxLength(1000);

                entity.Property(e => e.SiteCaption)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.SiteConfigXml).HasMaxLength(2000);

                entity.Property(e => e.SiteDtmdatabaseId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SiteDTMDatabaseId");

                entity.Property(e => e.SiteDtmuserId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SiteDTMUserId");

                entity.Property(e => e.SiteGooglePlayLink).HasMaxLength(1000);

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmTable>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("DTM_Tables");

                entity.Property(e => e.TableId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TableCaption)
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.TableDatabaseId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TableDesc)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmTablePermission>(entity =>
            {
                entity.HasKey(e => e.TablePermissionId);

                entity.ToTable("DTM_TablePermissions");

                entity.Property(e => e.TablePermissionId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TablePermissionActionId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TablePermissionTableId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TablePermissionUserGroupId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TablePermissionUserId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmUpfield>(entity =>
            {
                entity.HasKey(e => e.UpfieldId);

                entity.ToTable("DTM_UPFields");

                entity.Property(e => e.UpfieldId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UPFieldId");

                entity.Property(e => e.UpfieldFtploggin)
                    .HasMaxLength(4000)
                    .HasColumnName("UPFieldFTPLoggin")
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.UpfieldFtppath)
                    .HasMaxLength(4000)
                    .HasColumnName("UPFieldFTPPath")
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.UpfieldFtpsite)
                    .HasMaxLength(4000)
                    .HasColumnName("UPFieldFTPSite")
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.UpfieldPath)
                    .HasMaxLength(4000)
                    .HasColumnName("UPFieldPath")
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.UpfieldTableId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("UPFieldTableId");

                entity.Property(e => e.UpfieldUnqueNameFieldId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("UPFieldUnqueNameFieldId");

                entity.Property(e => e.UpfieldUploadTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("UPFieldUploadTypeId");
            });

            modelBuilder.Entity<DtmUploadType>(entity =>
            {
                entity.HasKey(e => e.UploadTypeId)
                    .HasName("PK_DTM_UploadType");

                entity.ToTable("DTM_UploadTypes");

                entity.Property(e => e.UploadTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UploadTypeName)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");
            });

            modelBuilder.Entity<DtmUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("DTM_Users");

                entity.HasIndex(e => e.UserName, "UK_DTM_Users_UserName")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");
            });

            modelBuilder.Entity<DtmUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("DTM_UserGroups");

                entity.HasIndex(e => e.UserGroupName, "UK_DTM_UserGroups_UserGroupName")
                    .IsUnique();

                entity.Property(e => e.UserGroupId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserGroupDescription)
                    .HasMaxLength(1000)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.UserGroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");
            });

            modelBuilder.Entity<DtmUserGroupsUser>(entity =>
            {
                entity.HasKey(e => e.UserGroupsUsersId);

                entity.ToTable("DTM_UserGroupsUsers");

                entity.HasIndex(e => new { e.UserGroupsUsersUserGroupId, e.UserGroupsUsersUserId }, "UK_DTM_UserGroupsUsers")
                    .IsUnique();

                entity.Property(e => e.UserGroupsUsersId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserGroupsUsersUserGroupId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserGroupsUsersUserId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmXmlObject>(entity =>
            {
                entity.HasKey(e => e.XmlObjectId);

                entity.ToTable("DTM_XmlObjects");

                entity.Property(e => e.XmlObjectId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.XmlObjectCustomSelect)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.XmlObjectName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.XmlObjectTableId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XmlObjectXslFile)
                    .HasMaxLength(4000)
                    .UseCollation("Hebrew_CI_AS");

                entity.Property(e => e.XmlObjectXslString)
                    .HasColumnType("text")
                    .UseCollation("Hebrew_CI_AS");
            });

            modelBuilder.Entity<DtmXmlObjectParameter>(entity =>
            {
                entity.HasKey(e => e.XmlObjectParametersId);

                entity.ToTable("DTM_XmlObjectParameters");

                entity.Property(e => e.XmlObjectParametersId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.XmlObjectParametersParameterId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XmlObjectParametersXmlObjectId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DtmtestFkTable>(entity =>
            {
                entity.ToTable("DTMTestFkTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FkLink)
                    .HasMaxLength(250)
                    .HasColumnName("fk_link");

                entity.Property(e => e.FkValue)
                    .HasMaxLength(50)
                    .HasColumnName("fk_value")
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");
            });

            modelBuilder.Entity<DtmtestTable>(entity =>
            {
                entity.ToTable("DTMTestTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FkId).HasColumnName("fk_id");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TestString)
                    .HasMaxLength(50)
                    .HasColumnName("test_string")
                    .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

                entity.Property(e => e.UploadFile)
                    .HasMaxLength(250)
                    .HasColumnName("upload_file");

                entity.Property(e => e.UploadFileName)
                    .HasMaxLength(250)
                    .HasColumnName("upload_file_name");

                entity.Property(e => e.UploadId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("upload_id");

                entity.Property(e => e.UploadName)
                    .HasMaxLength(50)
                    .HasColumnName("upload_name");

                entity.HasOne(d => d.Fk)
                    .WithMany(p => p.DtmtestTables)
                    .HasForeignKey(d => d.FkId)
                    .HasConstraintName("FK_DTMTestTable_DTMTestFkTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
