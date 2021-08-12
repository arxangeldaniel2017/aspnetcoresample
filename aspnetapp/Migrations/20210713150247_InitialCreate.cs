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
                    Id = table.Column<decimal>(type: "numeric", nullable: false),
                    ApplicationSiteId = table.Column<decimal>(type: "numeric", nullable: false),
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
                    ApplicationXmlObjectsId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationXmlObjectsApplicationId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationXmlObjectsXmlObjectId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationXmlObjectsHtmlTableCellId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmApplicationXmlObjects", x => x.ApplicationXmlObjectsId);
                });

            migrationBuilder.CreateTable(
                name: "DtmDatabases",
                columns: table => new
                {
                    DatabaseId = table.Column<decimal>(type: "numeric", nullable: false),
                    DatabaseName = table.Column<string>(type: "text", nullable: true),
                    DatabaseApplicationString = table.Column<string>(type: "text", nullable: true),
                    DatabaseConnString = table.Column<string>(type: "text", nullable: true),
                    DatabaseTypeId = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmDatabases", x => x.DatabaseId);
                });

            migrationBuilder.CreateTable(
                name: "DtmDatabaseTypes",
                columns: table => new
                {
                    DatabaseTypeId = table.Column<decimal>(type: "numeric", nullable: false),
                    DatabaseTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmDatabaseTypes", x => x.DatabaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFields",
                columns: table => new
                {
                    FieldId = table.Column<decimal>(type: "numeric", nullable: false),
                    FieldTableId = table.Column<decimal>(type: "numeric", nullable: false),
                    FieldTypeId = table.Column<decimal>(type: "numeric", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: true),
                    FieldCaption = table.Column<string>(type: "text", nullable: true),
                    FieldRequired = table.Column<bool>(type: "boolean", nullable: true),
                    FieldFkfieldId = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldUpfieldId = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldOrder = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldReadOnly = table.Column<bool>(type: "boolean", nullable: true),
                    FieldIsPk = table.Column<bool>(type: "boolean", nullable: false),
                    FieldAutoIncrement = table.Column<bool>(type: "boolean", nullable: true),
                    FieldAutoIncrementSeed = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldAutoIncrementStep = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldDataTypeString = table.Column<string>(type: "text", nullable: true),
                    FieldUnique = table.Column<bool>(type: "boolean", nullable: true),
                    FieldIsFilter = table.Column<bool>(type: "boolean", nullable: true),
                    FieldDoNotDisplay = table.Column<bool>(type: "boolean", nullable: true),
                    FieldDisplayOnly = table.Column<bool>(type: "boolean", nullable: true),
                    FieldParamValue = table.Column<string>(type: "text", nullable: true),
                    FieldIsQueryStringFilter = table.Column<bool>(type: "boolean", nullable: true),
                    FieldWidth = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldHeight = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldViewDescriptionChars = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldMaxChars = table.Column<decimal>(type: "numeric", nullable: true),
                    FieldUrlLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFields", x => x.FieldId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFieldTypes",
                columns: table => new
                {
                    FieldTypeId = table.Column<decimal>(type: "numeric", nullable: false),
                    FieldTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFieldTypes", x => x.FieldTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFilterGroups",
                columns: table => new
                {
                    FilterGroupId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterGroupName = table.Column<string>(type: "text", nullable: true),
                    FilterGroupOperatorId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterGroupFilterId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterGroupFilterOperatorId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterGroupOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFilterGroups", x => x.FilterGroupId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFilterParameters",
                columns: table => new
                {
                    FilterParametersId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterParametersFilterId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterParametersParameterId = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFilterParameters", x => x.FilterParametersId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFilters",
                columns: table => new
                {
                    FilterId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterName = table.Column<string>(type: "text", nullable: true),
                    FilterOperatorId = table.Column<decimal>(type: "numeric", nullable: false),
                    FilterFieldId = table.Column<decimal>(type: "numeric", nullable: true),
                    FilterFieldOperatorId = table.Column<decimal>(type: "numeric", nullable: true),
                    FilterCustomSelect = table.Column<string>(type: "text", nullable: true),
                    FilterDefaultValue = table.Column<string>(type: "text", nullable: true),
                    FilterOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFilters", x => x.FilterId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFkfields",
                columns: table => new
                {
                    FkfieldId = table.Column<decimal>(type: "numeric", nullable: false),
                    FkfieldTableId = table.Column<decimal>(type: "numeric", nullable: false),
                    FkfieldKeyFieldId = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFkfields", x => x.FkfieldId);
                });

            migrationBuilder.CreateTable(
                name: "DtmFkValues",
                columns: table => new
                {
                    FkValueId = table.Column<decimal>(type: "numeric", nullable: false),
                    FkValueFkfieldId = table.Column<decimal>(type: "numeric", nullable: false),
                    FkValueFieldId = table.Column<decimal>(type: "numeric", nullable: false),
                    FkvalueSeparator = table.Column<string>(type: "text", nullable: true),
                    FkvalueOrder = table.Column<decimal>(type: "numeric", nullable: true),
                    FkvalueDoNotDisplay = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmFkValues", x => x.FkValueId);
                });

            migrationBuilder.CreateTable(
                name: "DtmHtmlTableCells",
                columns: table => new
                {
                    HtmlTableCellId = table.Column<decimal>(type: "numeric", nullable: false),
                    HtmlTableCellHtmlTableRowId = table.Column<decimal>(type: "numeric", nullable: false),
                    HtmlTableCellPropertiesString = table.Column<string>(type: "text", nullable: true),
                    HtmlTableCellCollspan = table.Column<int>(type: "integer", nullable: true),
                    HtmlTableCellOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmHtmlTableCells", x => x.HtmlTableCellId);
                });

            migrationBuilder.CreateTable(
                name: "DtmHtmlTableRows",
                columns: table => new
                {
                    HtmlTableRowId = table.Column<decimal>(type: "numeric", nullable: false),
                    HtmlTableRowHtmlTableId = table.Column<decimal>(type: "numeric", nullable: false),
                    HtmlTableRowPropertiesString = table.Column<string>(type: "text", nullable: true),
                    HtmlTableRowRowspan = table.Column<int>(type: "integer", nullable: true),
                    HtmlTableRowOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmHtmlTableRows", x => x.HtmlTableRowId);
                });

            migrationBuilder.CreateTable(
                name: "DtmHtmlTables",
                columns: table => new
                {
                    HtmlTableId = table.Column<decimal>(type: "numeric", nullable: false),
                    HtmlTableName = table.Column<string>(type: "text", nullable: true),
                    HtmlTablePropertiesString = table.Column<string>(type: "text", nullable: true),
                    HtmlTableOrderBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmHtmlTables", x => x.HtmlTableId);
                });

            migrationBuilder.CreateTable(
                name: "DtmOperators",
                columns: table => new
                {
                    OperatorId = table.Column<decimal>(type: "numeric", nullable: false),
                    OperatorName = table.Column<string>(type: "text", nullable: true),
                    OperatorValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmOperators", x => x.OperatorId);
                });

            migrationBuilder.CreateTable(
                name: "DtmParameters",
                columns: table => new
                {
                    ParameterId = table.Column<decimal>(type: "numeric", nullable: false),
                    ParameterName = table.Column<string>(type: "text", nullable: true),
                    ParameterSiteId = table.Column<decimal>(type: "numeric", nullable: false),
                    ParameterParameterTypeId = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmParameters", x => x.ParameterId);
                });

            migrationBuilder.CreateTable(
                name: "DtmParameterTypes",
                columns: table => new
                {
                    ParameterTypeId = table.Column<decimal>(type: "numeric", nullable: false),
                    ParameterTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmParameterTypes", x => x.ParameterTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DtmSites",
                columns: table => new
                {
                    SiteId = table.Column<decimal>(type: "numeric", nullable: false),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    SiteCaption = table.Column<string>(type: "text", nullable: true),
                    SiteAppLinkIos = table.Column<string>(type: "text", nullable: true),
                    SiteAppLinkAndroid = table.Column<string>(type: "text", nullable: true),
                    SiteDtmdatabaseId = table.Column<decimal>(type: "numeric", nullable: true),
                    SiteDtmuserId = table.Column<decimal>(type: "numeric", nullable: true),
                    SiteConfigXml = table.Column<string>(type: "text", nullable: true),
                    SiteAppStoreLink = table.Column<string>(type: "text", nullable: true),
                    SiteGooglePlayLink = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmSites", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "DtmTablePermissions",
                columns: table => new
                {
                    TablePermissionId = table.Column<decimal>(type: "numeric", nullable: false),
                    TablePermissionTableId = table.Column<decimal>(type: "numeric", nullable: false),
                    TablePermissionActionId = table.Column<decimal>(type: "numeric", nullable: false),
                    TablePermissionUserGroupId = table.Column<decimal>(type: "numeric", nullable: true),
                    TablePermissionUserId = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmTablePermissions", x => x.TablePermissionId);
                });

            migrationBuilder.CreateTable(
                name: "DtmTables",
                columns: table => new
                {
                    TableId = table.Column<decimal>(type: "numeric", nullable: false),
                    TableDatabaseId = table.Column<decimal>(type: "numeric", nullable: false),
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
                    table.PrimaryKey("PK_DtmTables", x => x.TableId);
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
                    UpfieldId = table.Column<decimal>(type: "numeric", nullable: false),
                    UpfieldTableId = table.Column<decimal>(type: "numeric", nullable: true),
                    UpfieldPath = table.Column<string>(type: "text", nullable: true),
                    UpfieldUnqueNameFieldId = table.Column<decimal>(type: "numeric", nullable: true),
                    UpfieldFtpsite = table.Column<string>(type: "text", nullable: true),
                    UpfieldFtppath = table.Column<string>(type: "text", nullable: true),
                    UpfieldFtploggin = table.Column<string>(type: "text", nullable: true),
                    UpfieldUploadTypeId = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUpfields", x => x.UpfieldId);
                });

            migrationBuilder.CreateTable(
                name: "DtmUploadTypes",
                columns: table => new
                {
                    UploadTypeId = table.Column<decimal>(type: "numeric", nullable: false),
                    UploadTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUploadTypes", x => x.UploadTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DtmUserGroups",
                columns: table => new
                {
                    UserGroupId = table.Column<decimal>(type: "numeric", nullable: false),
                    UserGroupName = table.Column<string>(type: "text", nullable: true),
                    UserGroupDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUserGroups", x => x.UserGroupId);
                });

            migrationBuilder.CreateTable(
                name: "DtmUserGroupsUsers",
                columns: table => new
                {
                    UserGroupsUsersId = table.Column<decimal>(type: "numeric", nullable: false),
                    UserGroupsUsersUserGroupId = table.Column<decimal>(type: "numeric", nullable: false),
                    UserGroupsUsersUserId = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUserGroupsUsers", x => x.UserGroupsUsersId);
                });

            migrationBuilder.CreateTable(
                name: "DtmUsers",
                columns: table => new
                {
                    UserId = table.Column<decimal>(type: "numeric", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    UserPassword = table.Column<string>(type: "text", nullable: true),
                    UserIsAdministrator = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DtmXmlObjectParameters",
                columns: table => new
                {
                    XmlObjectParametersId = table.Column<decimal>(type: "numeric", nullable: false),
                    XmlObjectParametersXmlObjectId = table.Column<decimal>(type: "numeric", nullable: false),
                    XmlObjectParametersParameterId = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmXmlObjectParameters", x => x.XmlObjectParametersId);
                });

            migrationBuilder.CreateTable(
                name: "DtmXmlObjects",
                columns: table => new
                {
                    XmlObjectId = table.Column<decimal>(type: "numeric", nullable: false),
                    XmlObjectName = table.Column<string>(type: "text", nullable: true),
                    XmlObjectTableId = table.Column<decimal>(type: "numeric", nullable: true),
                    XmlObjectCustomSelect = table.Column<string>(type: "text", nullable: true),
                    XmlObjectXslString = table.Column<string>(type: "text", nullable: true),
                    XmlObjectXslFile = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DtmXmlObjects", x => x.XmlObjectId);
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
                    UploadId = table.Column<decimal>(type: "numeric", nullable: true),
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
