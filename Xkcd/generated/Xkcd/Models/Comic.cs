namespace Xkcd.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class Comic : Xkcd.Models.IComic
    {
        /// <summary>Backing field for Alt property</summary>
        private string _alt;

        public string Alt
        {
            get
            {
                return this._alt;
            }
            set
            {
                this._alt = value;
            }
        }
        /// <summary>Backing field for Day property</summary>
        private string _day;

        public string Day
        {
            get
            {
                return this._day;
            }
            set
            {
                this._day = value;
            }
        }
        /// <summary>Backing field for Img property</summary>
        private string _img;

        public string Img
        {
            get
            {
                return this._img;
            }
            set
            {
                this._img = value;
            }
        }
        /// <summary>Backing field for Link property</summary>
        private string _link;

        public string Link
        {
            get
            {
                return this._link;
            }
            set
            {
                this._link = value;
            }
        }
        /// <summary>Backing field for Month property</summary>
        private string _month;

        public string Month
        {
            get
            {
                return this._month;
            }
            set
            {
                this._month = value;
            }
        }
        /// <summary>Backing field for News property</summary>
        private string _news;

        public string News
        {
            get
            {
                return this._news;
            }
            set
            {
                this._news = value;
            }
        }
        /// <summary>Backing field for Num property</summary>
        private float? _num;

        public float? Num
        {
            get
            {
                return this._num;
            }
            set
            {
                this._num = value;
            }
        }
        /// <summary>Backing field for SafeTitle property</summary>
        private string _safeTitle;

        public string SafeTitle
        {
            get
            {
                return this._safeTitle;
            }
            set
            {
                this._safeTitle = value;
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
        /// <summary>Backing field for Transcript property</summary>
        private string _transcript;

        public string Transcript
        {
            get
            {
                return this._transcript;
            }
            set
            {
                this._transcript = value;
            }
        }
        /// <summary>Backing field for Year property</summary>
        private string _year;

        public string Year
        {
            get
            {
                return this._year;
            }
            set
            {
                this._year = value;
            }
        }
        /// <summary>Creates an new <see cref="Comic" /> instance.</summary>
        public Comic()
        {
        }
    }
    public partial interface IComic : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Alt { get; set; }
        string Day { get; set; }
        string Img { get; set; }
        string Link { get; set; }
        string Month { get; set; }
        string News { get; set; }
        float? Num { get; set; }
        string SafeTitle { get; set; }
        string Title { get; set; }
        string Transcript { get; set; }
        string Year { get; set; }
    }
}