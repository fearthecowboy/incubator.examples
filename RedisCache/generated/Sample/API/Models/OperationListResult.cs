namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Result of the request to list REST API operations. It contains a list of operations and a URL nextLink to get the next
    /// set of results.
    /// </summary>
    public partial class OperationListResult : Sample.API.Models.IOperationListResult, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for NextLink property</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        public string NextLink
        {
            get
            {
                return this._nextLink;
            }
            internal set
            {
                this._nextLink = value;
            }
        }
        /// <summary>Backing field for Value property</summary>
        private Sample.API.Models.IOperation[] _value;

        /// <summary>List of operations supported by the resource provider.</summary>
        public Sample.API.Models.IOperation[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
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
            if (Value != null ) {
                    for (int __i = 0; __i < Value.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Value[{__i}]", Value[__i]);
                    }
                  }
        }
    }
    /// Result of the request to list REST API operations. It contains a list of operations and a URL nextLink to get the next
    /// set of results.
    public partial interface IOperationListResult : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string NextLink { get;  }
        Sample.API.Models.IOperation[] Value { get; set; }
    }
}