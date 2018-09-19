namespace Times.Wire.Search.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class ArticleRelatedUrlsItemType : Times.Wire.Search.Models.IArticleRelatedUrlsItemType
    {
        /// <summary>Backing field for SuggestedLinkText property</summary>
        private string _suggestedLinkText;

        public string SuggestedLinkText
        {
            get
            {
                return this._suggestedLinkText;
            }
            set
            {
                this._suggestedLinkText = value;
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
        /// <summary>Creates an new <see cref="ArticleRelatedUrlsItemType" /> instance.</summary>
        public ArticleRelatedUrlsItemType()
        {
        }
    }
    public partial interface IArticleRelatedUrlsItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string SuggestedLinkText { get; set; }
        string Url { get; set; }
    }
}