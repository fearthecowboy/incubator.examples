namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Parameters for Redis import operation.</summary>
    public partial class ImportRDBParameters : Sample.API.Models.IImportRDBParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Files property</summary>
        private string[] _files;

        /// <summary>files to import.</summary>
        public string[] Files
        {
            get
            {
                return this._files;
            }
            set
            {
                this._files = value;
            }
        }
        /// <summary>Backing field for Format property</summary>
        private string _format;

        /// <summary>File format.</summary>
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
        /// <summary>Creates an new <see cref="ImportRDBParameters" /> instance.</summary>
        public ImportRDBParameters()
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
            await eventListener.AssertNotNull(nameof(Files), Files);
        }
    }
    /// Parameters for Redis import operation.
    public partial interface IImportRDBParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string[] Files { get; set; }
        string Format { get; set; }
    }
}