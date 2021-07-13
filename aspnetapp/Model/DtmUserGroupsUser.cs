using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmUserGroupsUser
    {
        [Key]
        public decimal UserGroupsUsersId { get; set; }
        public decimal UserGroupsUsersUserGroupId { get; set; }
        public decimal UserGroupsUsersUserId { get; set; }
    }
}
