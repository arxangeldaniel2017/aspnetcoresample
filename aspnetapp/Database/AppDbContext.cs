using Microsoft.EntityFrameworkCore;
using aspnetapp.Model;

namespace aspnetapp.Database {
    public class AppDbContext : DbContext {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<Test> Tests { get; set; }

        public  DbSet<DtmAction> DtmActions { get; set; }
        public  DbSet<DtmApplication> DtmApplications { get; set; }
        
        public  DbSet<DtmApplicationXmlObject> DtmApplicationXmlObjects { get; set; }
        public  DbSet<DtmDatabase> DtmDatabases { get; set; }
        public  DbSet<DtmDatabaseType> DtmDatabaseTypes { get; set; }
        public  DbSet<DtmField> DtmFields { get; set; }
        public  DbSet<DtmFieldType> DtmFieldTypes { get; set; }
        public  DbSet<DtmFilter> DtmFilters { get; set; }
        public  DbSet<DtmFilterGroup> DtmFilterGroups { get; set; }
        public  DbSet<DtmFilterParameter> DtmFilterParameters { get; set; }
        public  DbSet<DtmFkValue> DtmFkValues { get; set; }
        public  DbSet<DtmFkfield> DtmFkfields { get; set; }
        public  DbSet<DtmHtmlTable> DtmHtmlTables { get; set; }
        public  DbSet<DtmHtmlTableCell> DtmHtmlTableCells { get; set; }
        public  DbSet<DtmHtmlTableRow> DtmHtmlTableRows { get; set; }
        public  DbSet<DtmOperator> DtmOperators { get; set; }
        public  DbSet<DtmParameter> DtmParameters { get; set; }
        public  DbSet<DtmParameterType> DtmParameterTypes { get; set; }
        public  DbSet<DtmSite> DtmSites { get; set; }
        public  DbSet<DtmTable> DtmTables { get; set; }
        public  DbSet<DtmTablePermission> DtmTablePermissions { get; set; }
        public  DbSet<DtmUpfield> DtmUpfields { get; set; }
        public  DbSet<DtmUploadType> DtmUploadTypes { get; set; }
        public  DbSet<DtmUser> DtmUsers { get; set; }
        public  DbSet<DtmUserGroup> DtmUserGroups { get; set; }
        public  DbSet<DtmUserGroupsUser> DtmUserGroupsUsers { get; set; }
        public  DbSet<DtmXmlObject> DtmXmlObjects { get; set; }
        public  DbSet<DtmXmlObjectParameter> DtmXmlObjectParameters { get; set; }
        public  DbSet<DtmtestFkTable> DtmtestFkTables { get; set; }
        public  DbSet<DtmtestTable> DtmtestTables { get; set; }
    }
}