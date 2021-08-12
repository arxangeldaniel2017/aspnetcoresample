using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmUserGroupsUser
    {
        public int Id { get; set; }
        public int UserGroupsUsersUserGroupId { get; set; }
        public int UserGroupsUsersUserId { get; set; }
    }
}
