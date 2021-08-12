using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DtmActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActionName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationSiteId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationName = table.Column<string>(type: "text", nullable: true),
                    ApplicationCaption = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmApplicationXmlObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationXmlObjectsApplicationId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationXmlObjectsXmlObjectId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationXmlObjectsHtmlTableCellId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmApplicationXmlObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmDatabases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatabaseName = table.Column<string>(type: "text", nullable: true),
                    DatabaseApplicationString = table.Column<string>(type: "text", nullable: true),
                    DatabaseConnString = table.Column<string>(type: "text", nullable: true),
                    DatabaseTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmDatabases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmDatabaseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatabaseTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmDatabaseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldTableId = table.Column<int>(type: "integer", nullable: false),
                    FieldTypeId = table.Column<int>(type: "integer", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: true),
                    FieldCaption = table.Column<string>(type: "text", nullable: true),
                    FieldRequired = table.Column<bool>(type: "boolean", nullable: true),
                    FieldFkfieldId = table.Column<int>(type: "integer", nullable: true),
                    FieldUpfieldId = table.Column<int>(type: "integer", nullable: true),
                    FieldOrder = table.Column<int>(type: "integer", nullable: true),
                    FieldReadOnly = table.Column<bool>(type: "boolean", nullable: true),
                    FieldIsPk = table.Column<bool>(type: "boolean", nullable: false),
                    FieldAutoIncrement = table.Column<bool>(type: "boolean", nullable: true),
                    FieldAutoIncrementSeed = table.Column<int>(type: "integer", nullable: true),
                    FieldAutoIncrementStep = table.Column<int>(type: "integer", nullable: true),
                    FieldDataTypeString = table.Column<string>(type: "text", nullable: true),
                    FieldUnique = table.Column<bool>(type: "boolean", nullable: true),
                    FieldIsFilter = table.Column<bool>(type: "boolean", nullable: true),
                    FieldDoNotDisplay = table.Column<bool>(type: "boolean", nullable: true),
                    FieldDisplayOnly = table.Column<bool>(type: "boolean", nullable: true),
                    FieldParamValue = table.Column<string>(type: "text", nullable: true),
                    FieldIsQueryStringFilter = table.Column<bool>(type: "boolean", nullable: true),
                    FieldWidth = table.Column<int>(type: "integer", nullable: true),
                    FieldHeight = table.Column<int>(type: "integer", nullable: true),
                    FieldViewDescriptionChars = table.Column<int>(type: "integer", nullable: true),
                    FieldMaxChars = table.Column<int>(type: "integer", nullable: true),
                    FieldUrlLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFieldTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FieldTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFieldTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFilterGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilterGroupName = table.Column<string>(type: "text", nullable: true),
                    FilterGroupOperatorId = table.Column<int>(type: "integer", nullable: false),
                    FilterGroupFilterId = table.Column<int>(type: "integer", nullable: false),
                    FilterGroupFilterOperatorId = table.Column<int>(type: "integer", nullable: false),
                    FilterGroupOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFilterGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFilterParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilterParametersFilterId = table.Column<int>(type: "integer", nullable: false),
                    FilterParametersParameterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFilterParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFilters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilterName = table.Column<string>(type: "text", nullable: true),
                    FilterOperatorId = table.Column<int>(type: "integer", nullable: false),
                    FilterFieldId = table.Column<int>(type: "integer", nullable: true),
                    FilterFieldOperatorId = table.Column<int>(type: "integer", nullable: true),
                    FilterCustomSelect = table.Column<string>(type: "text", nullable: true),
                    FilterDefaultValue = table.Column<string>(type: "text", nullable: true),
                    FilterOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFilters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFkfields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FkfieldTableId = table.Column<int>(type: "integer", nullable: false),
                    FkfieldKeyFieldId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFkfields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmFkValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FkValueFkfieldId = table.Column<int>(type: "integer", nullable: false),
                    FkValueFieldId = table.Column<int>(type: "integer", nullable: false),
                    FkvalueSeparator = table.Column<string>(type: "text", nullable: true),
                    FkvalueOrder = table.Column<int>(type: "integer", nullable: true),
                    FkvalueDoNotDisplay = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFkValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmHtmlTableCells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HtmlTableCellHtmlTableRowId = table.Column<int>(type: "integer", nullable: false),
                    HtmlTableCellPropertiesString = table.Column<string>(type: "text", nullable: true),
                    HtmlTableCellCollspan = table.Column<int>(type: "integer", nullable: true),
                    HtmlTableCellOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmHtmlTableCells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmHtmlTableRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HtmlTableRowHtmlTableId = table.Column<int>(type: "integer", nullable: false),
                    HtmlTableRowPropertiesString = table.Column<string>(type: "text", nullable: true),
                    HtmlTableRowRowspan = table.Column<int>(type: "integer", nullable: true),
                    HtmlTableRowOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmHtmlTableRows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmHtmlTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HtmlTableName = table.Column<string>(type: "text", nullable: true),
                    HtmlTablePropertiesString = table.Column<string>(type: "text", nullable: true),
                    HtmlTableOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmHtmlTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmOperators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OperatorName = table.Column<string>(type: "text", nullable: true),
                    OperatorValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmOperators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParameterName = table.Column<string>(type: "text", nullable: true),
                    ParameterSiteId = table.Column<int>(type: "integer", nullable: false),
                    ParameterParameterTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmParameterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParameterTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmParameterTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmSites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    SiteCaption = table.Column<string>(type: "text", nullable: true),
                    SiteAppLinkIos = table.Column<string>(type: "text", nullable: true),
                    SiteAppLinkAndroid = table.Column<string>(type: "text", nullable: true),
                    SiteDtmdatabaseId = table.Column<int>(type: "integer", nullable: true),
                    SiteDtmuserId = table.Column<int>(type: "integer", nullable: true),
                    SiteConfigXml = table.Column<string>(type: "text", nullable: true),
                    SiteAppStoreLink = table.Column<string>(type: "text", nullable: true),
                    SiteGooglePlayLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmSites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmTablePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TablePermissionTableId = table.Column<int>(type: "integer", nullable: false),
                    TablePermissionActionId = table.Column<int>(type: "integer", nullable: false),
                    TablePermissionUserGroupId = table.Column<int>(type: "integer", nullable: true),
                    TablePermissionUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmTablePermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TableDatabaseId = table.Column<int>(type: "integer", nullable: false),
                    TableName = table.Column<string>(type: "text", nullable: true),
                    TableCaption = table.Column<string>(type: "text", nullable: true),
                    TableDesc = table.Column<string>(type: "text", nullable: true),
                    TableAllowPaging = table.Column<bool>(type: "boolean", nullable: true),
                    TablePageSize = table.Column<int>(type: "integer", nullable: true),
                    TableAllowSorting = table.Column<bool>(type: "boolean", nullable: true),
                    TableDisplayFilter = table.Column<bool>(type: "boolean", nullable: true),
                    TableIsAdd = table.Column<bool>(type: "boolean", nullable: true),
                    TableIsDelete = table.Column<bool>(type: "boolean", nullable: true),
                    TableIsUpdate = table.Column<bool>(type: "boolean", nullable: true),
                    TableIsScroll = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmtestFkTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FkValue = table.Column<string>(type: "text", nullable: true),
                    FkLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmtestFkTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmUpfields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UpfieldTableId = table.Column<int>(type: "integer", nullable: true),
                    UpfieldPath = table.Column<string>(type: "text", nullable: true),
                    UpfieldUnqueNameFieldId = table.Column<int>(type: "integer", nullable: true),
                    UpfieldFtpsite = table.Column<string>(type: "text", nullable: true),
                    UpfieldFtppath = table.Column<string>(type: "text", nullable: true),
                    UpfieldFtploggin = table.Column<string>(type: "text", nullable: true),
                    UpfieldUploadTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUpfields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmUploadTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UploadTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUploadTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmUserGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserGroupName = table.Column<string>(type: "text", nullable: true),
                    UserGroupDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUserGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmUserGroupsUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserGroupsUsersUserGroupId = table.Column<int>(type: "integer", nullable: false),
                    UserGroupsUsersUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUserGroupsUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    UserPassword = table.Column<string>(type: "text", nullable: true),
                    UserIsAdministrator = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmXmlObjectParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    XmlObjectParametersXmlObjectId = table.Column<int>(type: "integer", nullable: false),
                    XmlObjectParametersParameterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmXmlObjectParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmXmlObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    XmlObjectName = table.Column<string>(type: "text", nullable: true),
                    XmlObjectTableId = table.Column<int>(type: "integer", nullable: true),
                    XmlObjectCustomSelect = table.Column<string>(type: "text", nullable: true),
                    XmlObjectXslString = table.Column<string>(type: "text", nullable: true),
                    XmlObjectXslFile = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmXmlObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DtmtestTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FkId = table.Column<int>(type: "integer", nullable: true),
                    TestString = table.Column<string>(type: "text", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UploadId = table.Column<int>(type: "integer", nullable: true),
                    UploadName = table.Column<string>(type: "text", nullable: true),
                    UploadFile = table.Column<string>(type: "text", nullable: true),
                    UploadFileName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmtestTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DtmtestTables_DtmtestFkTables_FkId",
                        column: x => x.FkId,
                        principalTable: "DtmtestFkTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DtmtestTables_FkId",
                table: "DtmtestTables",
                column: "FkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DtmActions");

            migrationBuilder.DropTable(
                name: "DtmApplications");

            migrationBuilder.DropTable(
                name: "DtmApplicationXmlObjects");

            migrationBuilder.DropTable(
                name: "DtmDatabases");

            migrationBuilder.DropTable(
                name: "DtmDatabaseTypes");

            migrationBuilder.DropTable(
                name: "DtmFields");

            migrationBuilder.DropTable(
                name: "DtmFieldTypes");

            migrationBuilder.DropTable(
                name: "DtmFilterGroups");

            migrationBuilder.DropTable(
                name: "DtmFilterParameters");

            migrationBuilder.DropTable(
                name: "DtmFilters");

            migrationBuilder.DropTable(
                name: "DtmFkfields");

            migrationBuilder.DropTable(
                name: "DtmFkValues");

            migrationBuilder.DropTable(
                name: "DtmHtmlTableCells");

            migrationBuilder.DropTable(
                name: "DtmHtmlTableRows");

            migrationBuilder.DropTable(
                name: "DtmHtmlTables");

            migrationBuilder.DropTable(
                name: "DtmOperators");

            migrationBuilder.DropTable(
                name: "DtmParameters");

            migrationBuilder.DropTable(
                name: "DtmParameterTypes");

            migrationBuilder.DropTable(
                name: "DtmSites");

            migrationBuilder.DropTable(
                name: "DtmTablePermissions");

            migrationBuilder.DropTable(
                name: "DtmTables");

            migrationBuilder.DropTable(
                name: "DtmtestTables");

            migrationBuilder.DropTable(
                name: "DtmUpfields");

            migrationBuilder.DropTable(
                name: "DtmUploadTypes");

            migrationBuilder.DropTable(
                name: "DtmUserGroups");

            migrationBuilder.DropTable(
                name: "DtmUserGroupsUsers");

            migrationBuilder.DropTable(
                name: "DtmUsers");

            migrationBuilder.DropTable(
                name: "DtmXmlObjectParameters");

            migrationBuilder.DropTable(
                name: "DtmXmlObjects");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "DtmtestFkTables");
        }
    }
}
