namespace Times.Wire.Search.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class ArticleMultimediaItemType : Times.Wire.Search.Models.IArticleMultimediaItemType
    {
        /// <summary>Backing field for Caption property</summary>
        private string _caption;

        public string Caption
        {
            get
            {
                return this._caption;
            }
            set
            {
                this._caption = value;
            }
        }
        /// <summary>Backing field for Copyright property</summary>
        private string _copyright;

        public string Copyright
        {
            get
            {
                return this._copyright;
            }
            set
            {
                this._copyright = value;
            }
        }
        /// <summary>Backing field for Format property</summary>
        private string _format;

        public string Format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }
        /// <summary>Backing field for Height property</summary>
        private int? _height;

        public int? Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        /// <summary>Backing field for Subtype property</summary>
        private string _subtype;

        public string Subtype
        {
            get
            {
                return this._subtype;
            }
            set
            {
                this._subtype = value;
            }
        }
        /// <summary>Backing field for Type property</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
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
        /// <summary>Backing field for Width property</summary>
        private int? _width;

        public int? Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }
        /// <summary>Creates an new <see cref="ArticleMultimediaItemType" /> instance.</summary>
        public ArticleMultimediaItemType()
        {
        }
    }
    public partial interface IArticleMultimediaItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Caption { get; set; }
        string Copyright { get; set; }
        string Format { get; set; }
        int? Height { get; set; }
        string Subtype { get; set; }
        string Type { get; set; }
        string Url { get; set; }
        int? Width { get; set; }
    }
}