using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmTablePermission
    {
        public decimal TablePermissionId { get; set; }
        public decimal TablePermissionTableId { get; set; }
        public decimal TablePermissionActionId { get; set; }
        public decimal? TablePermissionUserGroupId { get; set; }
        public decimal? TablePermissionUserId { get; set; }
    }
}
