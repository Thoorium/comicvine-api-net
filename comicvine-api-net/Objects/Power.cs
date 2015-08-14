﻿using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Thoorium.Comicvine.Objects
{
    public class Power
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        public string Birth { get; set; }

        public List<Character> Characters { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }
    }
}