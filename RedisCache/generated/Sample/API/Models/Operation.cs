namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>REST API operation</summary>
    public partial class Operation : Sample.API.Models.IOperation, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Display property</summary>
        private Sample.API.Models.IOperationDisplay _display;

        /// <summary>The object that describes the operation.</summary>
        public Sample.API.Models.IOperationDisplay Display
        {
            get
            {
                return this._display;
            }
            set
            {
                this._display = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Operation name: {provider}/{resource}/{operation}</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
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
            await eventListener.AssertObjectIsValid(nameof(Display), Display);
        }
    }
    /// REST API operation
    public partial interface IOperation : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IOperationDisplay Display { get; set; }
        string Name { get; set; }
    }
}