using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmTablePermission
    {
        public int Id { get; set; }
        public int TablePermissionTableId { get; set; }
        public int TablePermissionActionId { get; set; }
        public int? TablePermissionUserGroupId { get; set; }
        public int? TablePermissionUserId { get; set; }
    }
}
