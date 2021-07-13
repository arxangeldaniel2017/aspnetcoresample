using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmUser
    {
        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool? UserIsAdministrator { get; set; }
    }
}
