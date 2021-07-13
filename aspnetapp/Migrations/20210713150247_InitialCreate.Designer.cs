﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using aspnetapp.Database;

namespace aspnetapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210713150247_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("aspnetapp.Model.DtmAction", b =>
                {
                    b.Property<int>("ActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActionName")
                        .HasColumnType("text");

                    b.HasKey("ActionId");

                    b.ToTable("DtmActions");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmApplication", b =>
                {
                    b.Property<decimal>("ApplicationId")
                        .HasColumnType("numeric");

                    b.Property<string>("ApplicationCaption")
                        .HasColumnType("text");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("text");

                    b.Property<decimal>("ApplicationSiteId")
                        .HasColumnType("numeric");

                    b.HasKey("ApplicationId");

                    b.ToTable("DtmApplications");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmApplicationXmlObject", b =>
                {
                    b.Property<int>("ApplicationXmlObjectsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicationXmlObjectsApplicationId")
                        .HasColumnType("integer");

                    b.Property<int>("ApplicationXmlObjectsHtmlTableCellId")
                        .HasColumnType("integer");

                    b.Property<int>("ApplicationXmlObjectsXmlObjectId")
                        .HasColumnType("integer");

                    b.HasKey("ApplicationXmlObjectsId");

                    b.ToTable("DtmApplicationXmlObjects");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmDatabase", b =>
                {
                    b.Property<decimal>("DatabaseId")
                        .HasColumnType("numeric");

                    b.Property<string>("DatabaseApplicationString")
                        .HasColumnType("text");

                    b.Property<string>("DatabaseConnString")
                        .HasColumnType("text");

                    b.Property<string>("DatabaseName")
                        .HasColumnType("text");

                    b.Property<decimal?>("DatabaseTypeId")
                        .HasColumnType("numeric");

                    b.HasKey("DatabaseId");

                    b.ToTable("DtmDatabases");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmDatabaseType", b =>
                {
                    b.Property<decimal>("DatabaseTypeId")
                        .HasColumnType("numeric");

                    b.Property<string>("DatabaseTypeName")
                        .HasColumnType("text");

                    b.HasKey("DatabaseTypeId");

                    b.ToTable("DtmDatabaseTypes");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmField", b =>
                {
                    b.Property<decimal>("FieldId")
                        .HasColumnType("numeric");

                    b.Property<bool?>("FieldAutoIncrement")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("FieldAutoIncrementSeed")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("FieldAutoIncrementStep")
                        .HasColumnType("numeric");

                    b.Property<string>("FieldCaption")
                        .HasColumnType("text");

                    b.Property<string>("FieldDataTypeString")
                        .HasColumnType("text");

                    b.Property<bool?>("FieldDisplayOnly")
                        .HasColumnType("boolean");

                    b.Property<bool?>("FieldDoNotDisplay")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("FieldFkfieldId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("FieldHeight")
                        .HasColumnType("numeric");

                    b.Property<bool?>("FieldIsFilter")
                        .HasColumnType("boolean");

                    b.Property<bool>("FieldIsPk")
                        .HasColumnType("boolean");

                    b.Property<bool?>("FieldIsQueryStringFilter")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("FieldMaxChars")
                        .HasColumnType("numeric");

                    b.Property<string>("FieldName")
                        .HasColumnType("text");

                    b.Property<decimal?>("FieldOrder")
                        .HasColumnType("numeric");

                    b.Property<string>("FieldParamValue")
                        .HasColumnType("text");

                    b.Property<bool?>("FieldReadOnly")
                        .HasColumnType("boolean");

                    b.Property<bool?>("FieldRequired")
                        .HasColumnType("boolean");

                    b.Property<decimal>("FieldTableId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FieldTypeId")
                        .HasColumnType("numeric");

                    b.Property<bool?>("FieldUnique")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("FieldUpfieldId")
                        .HasColumnType("numeric");

                    b.Property<string>("FieldUrlLink")
                        .HasColumnType("text");

                    b.Property<decimal?>("FieldViewDescriptionChars")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("FieldWidth")
                        .HasColumnType("numeric");

                    b.HasKey("FieldId");

                    b.ToTable("DtmFields");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmFieldType", b =>
                {
                    b.Property<decimal>("FieldTypeId")
                        .HasColumnType("numeric");

                    b.Property<string>("FieldTypeName")
                        .HasColumnType("text");

                    b.HasKey("FieldTypeId");

                    b.ToTable("DtmFieldTypes");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmFilter", b =>
                {
                    b.Property<decimal>("FilterId")
                        .HasColumnType("numeric");

                    b.Property<string>("FilterCustomSelect")
                        .HasColumnType("text");

                    b.Property<string>("FilterDefaultValue")
                        .HasColumnType("text");

                    b.Property<decimal?>("FilterFieldId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("FilterFieldOperatorId")
                        .HasColumnType("numeric");

                    b.Property<string>("FilterName")
                        .HasColumnType("text");

                    b.Property<decimal>("FilterOperatorId")
                        .HasColumnType("numeric");

                    b.Property<int>("FilterOrderBy")
                        .HasColumnType("integer");

                    b.HasKey("FilterId");

                    b.ToTable("DtmFilters");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmFilterGroup", b =>
                {
                    b.Property<decimal>("FilterGroupId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FilterGroupFilterId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FilterGroupFilterOperatorId")
                        .HasColumnType("numeric");

                    b.Property<string>("FilterGroupName")
                        .HasColumnType("text");

                    b.Property<decimal>("FilterGroupOperatorId")
                        .HasColumnType("numeric");

                    b.Property<int>("FilterGroupOrderBy")
                        .HasColumnType("integer");

                    b.HasKey("FilterGroupId");

                    b.ToTable("DtmFilterGroups");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmFilterParameter", b =>
                {
                    b.Property<decimal>("FilterParametersId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FilterParametersFilterId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FilterParametersParameterId")
                        .HasColumnType("numeric");

                    b.HasKey("FilterParametersId");

                    b.ToTable("DtmFilterParameters");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmFkValue", b =>
                {
                    b.Property<decimal>("FkValueId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FkValueFieldId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FkValueFkfieldId")
                        .HasColumnType("numeric");

                    b.Property<bool?>("FkvalueDoNotDisplay")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("FkvalueOrder")
                        .HasColumnType("numeric");

                    b.Property<string>("FkvalueSeparator")
                        .HasColumnType("text");

                    b.HasKey("FkValueId");

                    b.ToTable("DtmFkValues");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmFkfield", b =>
                {
                    b.Property<decimal>("FkfieldId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FkfieldKeyFieldId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FkfieldTableId")
                        .HasColumnType("numeric");

                    b.HasKey("FkfieldId");

                    b.ToTable("DtmFkfields");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmHtmlTable", b =>
                {
                    b.Property<decimal>("HtmlTableId")
                        .HasColumnType("numeric");

                    b.Property<string>("HtmlTableName")
                        .HasColumnType("text");

                    b.Property<int>("HtmlTableOrderBy")
                        .HasColumnType("integer");

                    b.Property<string>("HtmlTablePropertiesString")
                        .HasColumnType("text");

                    b.HasKey("HtmlTableId");

                    b.ToTable("DtmHtmlTables");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmHtmlTableCell", b =>
                {
                    b.Property<decimal>("HtmlTableCellId")
                        .HasColumnType("numeric");

                    b.Property<int?>("HtmlTableCellCollspan")
                        .HasColumnType("integer");

                    b.Property<decimal>("HtmlTableCellHtmlTableRowId")
                        .HasColumnType("numeric");

                    b.Property<int>("HtmlTableCellOrderBy")
                        .HasColumnType("integer");

                    b.Property<string>("HtmlTableCellPropertiesString")
                        .HasColumnType("text");

                    b.HasKey("HtmlTableCellId");

                    b.ToTable("DtmHtmlTableCells");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmHtmlTableRow", b =>
                {
                    b.Property<decimal>("HtmlTableRowId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("HtmlTableRowHtmlTableId")
                        .HasColumnType("numeric");

                    b.Property<int>("HtmlTableRowOrderBy")
                        .HasColumnType("integer");

                    b.Property<string>("HtmlTableRowPropertiesString")
                        .HasColumnType("text");

                    b.Property<int?>("HtmlTableRowRowspan")
                        .HasColumnType("integer");

                    b.HasKey("HtmlTableRowId");

                    b.ToTable("DtmHtmlTableRows");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmOperator", b =>
                {
                    b.Property<decimal>("OperatorId")
                        .HasColumnType("numeric");

                    b.Property<string>("OperatorName")
                        .HasColumnType("text");

                    b.Property<string>("OperatorValue")
                        .HasColumnType("text");

                    b.HasKey("OperatorId");

                    b.ToTable("DtmOperators");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmParameter", b =>
                {
                    b.Property<decimal>("ParameterId")
                        .HasColumnType("numeric");

                    b.Property<string>("ParameterName")
                        .HasColumnType("text");

                    b.Property<decimal>("ParameterParameterTypeId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ParameterSiteId")
                        .HasColumnType("numeric");

                    b.HasKey("ParameterId");

                    b.ToTable("DtmParameters");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmParameterType", b =>
                {
                    b.Property<decimal>("ParameterTypeId")
                        .HasColumnType("numeric");

                    b.Property<string>("ParameterTypeName")
                        .HasColumnType("text");

                    b.HasKey("ParameterTypeId");

                    b.ToTable("DtmParameterTypes");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmSite", b =>
                {
                    b.Property<decimal>("SiteId")
                        .HasColumnType("numeric");

                    b.Property<string>("SiteAppLinkAndroid")
                        .HasColumnType("text");

                    b.Property<string>("SiteAppLinkIos")
                        .HasColumnType("text");

                    b.Property<string>("SiteAppStoreLink")
                        .HasColumnType("text");

                    b.Property<string>("SiteCaption")
                        .HasColumnType("text");

                    b.Property<string>("SiteConfigXml")
                        .HasColumnType("text");

                    b.Property<decimal?>("SiteDtmdatabaseId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("SiteDtmuserId")
                        .HasColumnType("numeric");

                    b.Property<string>("SiteGooglePlayLink")
                        .HasColumnType("text");

                    b.Property<string>("SiteName")
                        .HasColumnType("text");

                    b.HasKey("SiteId");

                    b.ToTable("DtmSites");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmTable", b =>
                {
                    b.Property<decimal>("TableId")
                        .HasColumnType("numeric");

                    b.Property<bool?>("TableAllowPaging")
                        .HasColumnType("boolean");

                    b.Property<bool?>("TableAllowSorting")
                        .HasColumnType("boolean");

                    b.Property<string>("TableCaption")
                        .HasColumnType("text");

                    b.Property<decimal>("TableDatabaseId")
                        .HasColumnType("numeric");

                    b.Property<string>("TableDesc")
                        .HasColumnType("text");

                    b.Property<bool?>("TableDisplayFilter")
                        .HasColumnType("boolean");

                    b.Property<bool?>("TableIsAdd")
                        .HasColumnType("boolean");

                    b.Property<bool?>("TableIsDelete")
                        .HasColumnType("boolean");

                    b.Property<bool?>("TableIsScroll")
                        .HasColumnType("boolean");

                    b.Property<bool?>("TableIsUpdate")
                        .HasColumnType("boolean");

                    b.Property<string>("TableName")
                        .HasColumnType("text");

                    b.Property<int?>("TablePageSize")
                        .HasColumnType("integer");

                    b.HasKey("TableId");

                    b.ToTable("DtmTables");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmTablePermission", b =>
                {
                    b.Property<decimal>("TablePermissionId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TablePermissionActionId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TablePermissionTableId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("TablePermissionUserGroupId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("TablePermissionUserId")
                        .HasColumnType("numeric");

                    b.HasKey("TablePermissionId");

                    b.ToTable("DtmTablePermissions");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmUpfield", b =>
                {
                    b.Property<decimal>("UpfieldId")
                        .HasColumnType("numeric");

                    b.Property<string>("UpfieldFtploggin")
                        .HasColumnType("text");

                    b.Property<string>("UpfieldFtppath")
                        .HasColumnType("text");

                    b.Property<string>("UpfieldFtpsite")
                        .HasColumnType("text");

                    b.Property<string>("UpfieldPath")
                        .HasColumnType("text");

                    b.Property<decimal?>("UpfieldTableId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("UpfieldUnqueNameFieldId")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("UpfieldUploadTypeId")
                        .HasColumnType("numeric");

                    b.HasKey("UpfieldId");

                    b.ToTable("DtmUpfields");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmUploadType", b =>
                {
                    b.Property<decimal>("UploadTypeId")
                        .HasColumnType("numeric");

                    b.Property<string>("UploadTypeName")
                        .HasColumnType("text");

                    b.HasKey("UploadTypeId");

                    b.ToTable("DtmUploadTypes");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmUser", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric");

                    b.Property<bool?>("UserIsAdministrator")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("DtmUsers");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmUserGroup", b =>
                {
                    b.Property<decimal>("UserGroupId")
                        .HasColumnType("numeric");

                    b.Property<string>("UserGroupDescription")
                        .HasColumnType("text");

                    b.Property<string>("UserGroupName")
                        .HasColumnType("text");

                    b.HasKey("UserGroupId");

                    b.ToTable("DtmUserGroups");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmUserGroupsUser", b =>
                {
                    b.Property<decimal>("UserGroupsUsersId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UserGroupsUsersUserGroupId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UserGroupsUsersUserId")
                        .HasColumnType("numeric");

                    b.HasKey("UserGroupsUsersId");

                    b.ToTable("DtmUserGroupsUsers");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmXmlObject", b =>
                {
                    b.Property<decimal>("XmlObjectId")
                        .HasColumnType("numeric");

                    b.Property<string>("XmlObjectCustomSelect")
                        .HasColumnType("text");

                    b.Property<string>("XmlObjectName")
                        .HasColumnType("text");

                    b.Property<decimal?>("XmlObjectTableId")
                        .HasColumnType("numeric");

                    b.Property<string>("XmlObjectXslFile")
                        .HasColumnType("text");

                    b.Property<string>("XmlObjectXslString")
                        .HasColumnType("text");

                    b.HasKey("XmlObjectId");

                    b.ToTable("DtmXmlObjects");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmXmlObjectParameter", b =>
                {
                    b.Property<decimal>("XmlObjectParametersId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("XmlObjectParametersParameterId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("XmlObjectParametersXmlObjectId")
                        .HasColumnType("numeric");

                    b.HasKey("XmlObjectParametersId");

                    b.ToTable("DtmXmlObjectParameters");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmtestFkTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FkLink")
                        .HasColumnType("text");

                    b.Property<string>("FkValue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DtmtestFkTables");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmtestTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FkId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TestString")
                        .HasColumnType("text");

                    b.Property<string>("UploadFile")
                        .HasColumnType("text");

                    b.Property<string>("UploadFileName")
                        .HasColumnType("text");

                    b.Property<decimal?>("UploadId")
                        .HasColumnType("numeric");

                    b.Property<string>("UploadName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FkId");

                    b.ToTable("DtmtestTables");
                });

            modelBuilder.Entity("aspnetapp.Model.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmtestTable", b =>
                {
                    b.HasOne("aspnetapp.Model.DtmtestFkTable", "Fk")
                        .WithMany("DtmtestTables")
                        .HasForeignKey("FkId");

                    b.Navigation("Fk");
                });

            modelBuilder.Entity("aspnetapp.Model.DtmtestFkTable", b =>
                {
                    b.Navigation("DtmtestTables");
                });
#pragma warning restore 612, 618
        }
    }
}
