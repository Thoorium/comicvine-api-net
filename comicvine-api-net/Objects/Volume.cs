using RestSharp.Deserializers;

namespace Thoorium.Comicvine.Objects
{
    public class Volume
    {
        public string Aliases { get; set; }

        [DeserializeAs(Name = "api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [DeserializeAs(Name = "count_of_issues")]
        public int CountOfIssues { get; set; }

        [DeserializeAs(Name = "date_added")]
        public string DateAdded { get; set; }

        [DeserializeAs(Name = "date_last_updated")]
        public string DateLastUpdated { get; set; }

        public string Deck { get; set; }

        public string Description { get; set; }

        [DeserializeAs(Name = "first_issue")]
        public VolumeIssue FirstIssue { get; set; }

        public string Id { get; set; }

        public VolumeImage Image { get; set; }

        [DeserializeAs(Name = "last_issue")]
        public VolumeIssue LastIssue { get; set; }

        public string Name { get; set; }

        [DeserializeAs(Name = "site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [DeserializeAs(Name = "start_year")]
        public string StartYear { get; set; }

        [DeserializeAs(Name = "resource_type")]
        public string ResourceType { get; set; }

        public class VolumeIssue
        {
            [DeserializeAs(Name = "api_detail_url")]
            public string ApiDetailUrl { get; set; }

            public string Id { get; set; }

            public string Name { get; set; }

            [DeserializeAs(Name = "issue_number")]
            public string IssueNumber { get; set; }
        }

        public class VolumeImage
        {
            [DeserializeAs(Name = "icon_url")]
            public string IconUrl { get; set; }

            [DeserializeAs(Name = "medium_url")]
            public string MediumUrl { get; set; }

            [DeserializeAs(Name = "screen_url")]
            public string ScreenUrl { get; set; }

            [DeserializeAs(Name = "small_url")]
            public string SmallUrl { get; set; }

            [DeserializeAs(Name = "super_url")]
            public string SuperUrl { get; set; }

            [DeserializeAs(Name = "thumb_url")]
            public string ThumbUrl { get; set; }

            [DeserializeAs(Name = "tiny_url")]
            public string TinyUrl { get; set; }
        }
    }
}