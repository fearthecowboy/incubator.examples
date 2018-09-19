namespace Times.Wire.Search.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class ArticlesListBySource200ApplicationJson : Times.Wire.Search.Models.IArticlesListBySource200ApplicationJson, Microsoft.Rest.ClientRuntime.IValidates
    {
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
        /// <summary>Backing field for NumResults property</summary>
        private int? _numResults;

        public int? NumResults
        {
            get
            {
                return this._numResults;
            }
            set
            {
                this._numResults = value;
            }
        }
        /// <summary>Backing field for Results property</summary>
        private Times.Wire.Search.Models.IArticle[] _results;

        public Times.Wire.Search.Models.IArticle[] Results
        {
            get
            {
                return this._results;
            }
            set
            {
                this._results = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private string _status;

        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Creates an new <see cref="ArticlesListBySource200ApplicationJson" /> instance.</summary>
        public ArticlesListBySource200ApplicationJson()
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
            if (Results != null ) {
                    for (int __i = 0; __i < Results.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Results[{__i}]", Results[__i]);
                    }
                  }
        }
    }
    public partial interface IArticlesListBySource200ApplicationJson : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Copyright { get; set; }
        int? NumResults { get; set; }
        Times.Wire.Search.Models.IArticle[] Results { get; set; }
        string Status { get; set; }
    }
}