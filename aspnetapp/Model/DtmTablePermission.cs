using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmTablePermission
    {
        [Key]
        public decimal TablePermissionId { get; set; }
        public decimal TablePermissionTableId { get; set; }
        public decimal TablePermissionActionId { get; set; }
        public decimal? TablePermissionUserGroupId { get; set; }
        public decimal? TablePermissionUserId { get; set; }
    }
}
