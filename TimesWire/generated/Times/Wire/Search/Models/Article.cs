namespace Times.Wire.Search.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class Article : Times.Wire.Search.Models.IArticle, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Abstract property</summary>
        private string _abstract;

        public string Abstract
        {
            get
            {
                return this._abstract;
            }
            set
            {
                this._abstract = value;
            }
        }
        /// <summary>Backing field for BlogName property</summary>
        private string _blogName;

        public string BlogName
        {
            get
            {
                return this._blogName;
            }
            set
            {
                this._blogName = value;
            }
        }
        /// <summary>Backing field for Byline property</summary>
        private string _byline;

        public string Byline
        {
            get
            {
                return this._byline;
            }
            set
            {
                this._byline = value;
            }
        }
        /// <summary>Backing field for CreatedDate property</summary>
        private string _createdDate;

        public string CreatedDate
        {
            get
            {
                return this._createdDate;
            }
            set
            {
                this._createdDate = value;
            }
        }
        /// <summary>Backing field for DesFacet property</summary>
        private string[] _desFacet;

        public string[] DesFacet
        {
            get
            {
                return this._desFacet;
            }
            set
            {
                this._desFacet = value;
            }
        }
        /// <summary>Backing field for GeoFacet property</summary>
        private string[] _geoFacet;

        public string[] GeoFacet
        {
            get
            {
                return this._geoFacet;
            }
            set
            {
                this._geoFacet = value;
            }
        }
        /// <summary>Backing field for Headline property</summary>
        private string _headline;

        public string Headline
        {
            get
            {
                return this._headline;
            }
            set
            {
                this._headline = value;
            }
        }
        /// <summary>Backing field for ItemType property</summary>
        private string _itemType;

        public string ItemType
        {
            get
            {
                return this._itemType;
            }
            set
            {
                this._itemType = value;
            }
        }
        /// <summary>Backing field for Kicker property</summary>
        private string _kicker;

        public string Kicker
        {
            get
            {
                return this._kicker;
            }
            set
            {
                this._kicker = value;
            }
        }
        /// <summary>Backing field for MaterialTypeFacet property</summary>
        private string _materialTypeFacet;

        public string MaterialTypeFacet
        {
            get
            {
                return this._materialTypeFacet;
            }
            set
            {
                this._materialTypeFacet = value;
            }
        }
        /// <summary>Backing field for Multimedia property</summary>
        private Times.Wire.Search.Models.IArticleMultimediaItemType[] _multimedia;

        public Times.Wire.Search.Models.IArticleMultimediaItemType[] Multimedia
        {
            get
            {
                return this._multimedia;
            }
            set
            {
                this._multimedia = value;
            }
        }
        /// <summary>Backing field for OrgFacet property</summary>
        private string _orgFacet;

        public string OrgFacet
        {
            get
            {
                return this._orgFacet;
            }
            set
            {
                this._orgFacet = value;
            }
        }
        /// <summary>Backing field for PerFacet property</summary>
        private string[] _perFacet;

        public string[] PerFacet
        {
            get
            {
                return this._perFacet;
            }
            set
            {
                this._perFacet = value;
            }
        }
        /// <summary>Backing field for PublishedDate property</summary>
        private string _publishedDate;

        public string PublishedDate
        {
            get
            {
                return this._publishedDate;
            }
            set
            {
                this._publishedDate = value;
            }
        }
        /// <summary>Backing field for RelatedUrls property</summary>
        private Times.Wire.Search.Models.IArticleRelatedUrlsItemType[] _relatedUrls;

        public Times.Wire.Search.Models.IArticleRelatedUrlsItemType[] RelatedUrls
        {
            get
            {
                return this._relatedUrls;
            }
            set
            {
                this._relatedUrls = value;
            }
        }
        /// <summary>Backing field for Section property</summary>
        private string _section;

        public string Section
        {
            get
            {
                return this._section;
            }
            set
            {
                this._section = value;
            }
        }
        /// <summary>Backing field for ShortUrl property</summary>
        private string _shortUrl;

        public string ShortUrl
        {
            get
            {
                return this._shortUrl;
            }
            set
            {
                this._shortUrl = value;
            }
        }
        /// <summary>Backing field for Source property</summary>
        private string _source;

        public string Source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }
        /// <summary>Backing field for Subsection property</summary>
        private string _subsection;

        public string Subsection
        {
            get
            {
                return this._subsection;
            }
            set
            {
                this._subsection = value;
            }
        }
        /// <summary>Backing field for ThumbnailStandard property</summary>
        private string _thumbnailStandard;

        public string ThumbnailStandard
        {
            get
            {
                return this._thumbnailStandard;
            }
            set
            {
                this._thumbnailStandard = value;
            }
        }
        /// <summary>Backing field for Title property</summary>
        private string _title;

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        /// <summary>Backing field for UpdatedDate property</summary>
        private string _updatedDate;

        public string UpdatedDate
        {
            get
            {
                return this._updatedDate;
            }
            set
            {
                this._updatedDate = value;
            }
        }
        /// <summary>Backing field for Url property</summary>
        private string _url;

        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
        }
        /// <summary>Creates an new <see cref="Article" /> instance.</summary>
        public Article()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            if (Multimedia != null ) {
                    for (int __i = 0; __i < Multimedia.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Multimedia[{__i}]", Multimedia[__i]);
                    }
                  }
            if (RelatedUrls != null ) {
                    for (int __i = 0; __i < RelatedUrls.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"RelatedUrls[{__i}]", RelatedUrls[__i]);
                    }
                  }
        }
    }
    public partial interface IArticle : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Abstract { get; set; }
        string BlogName { get; set; }
        string Byline { get; set; }
        string CreatedDate { get; set; }
        string[] DesFacet { get; set; }
        string[] GeoFacet { get; set; }
        string Headline { get; set; }
        string ItemType { get; set; }
        string Kicker { get; set; }
        string MaterialTypeFacet { get; set; }
        Times.Wire.Search.Models.IArticleMultimediaItemType[] Multimedia { get; set; }
        string OrgFacet { get; set; }
        string[] PerFacet { get; set; }
        string PublishedDate { get; set; }
        Times.Wire.Search.Models.IArticleRelatedUrlsItemType[] RelatedUrls { get; set; }
        string Section { get; set; }
        string ShortUrl { get; set; }
        string Source { get; set; }
        string Subsection { get; set; }
        string ThumbnailStandard { get; set; }
        string Title { get; set; }
        string UpdatedDate { get; set; }
        string Url { get; set; }
    }
}