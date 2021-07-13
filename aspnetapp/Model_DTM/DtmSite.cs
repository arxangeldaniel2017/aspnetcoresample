﻿using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmSite
    {
        public decimal SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteCaption { get; set; }
        public string SiteAppLinkIos { get; set; }
        public string SiteAppLinkAndroid { get; set; }
        public decimal? SiteDtmdatabaseId { get; set; }
        public decimal? SiteDtmuserId { get; set; }
        public string SiteConfigXml { get; set; }
        public string SiteAppStoreLink { get; set; }
        public string SiteGooglePlayLink { get; set; }
    }
}
