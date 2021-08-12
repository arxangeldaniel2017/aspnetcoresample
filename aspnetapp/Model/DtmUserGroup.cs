using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmUserGroup
    {
        public int Id { get; set; }
        public string UserGroupName { get; set; }
        public string UserGroupDescription { get; set; }
    }
}
