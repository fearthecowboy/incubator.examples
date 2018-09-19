namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Parameters supplied to the Update Redis operation.</summary>
    public partial class RedisUpdateParameters : Sample.API.Models.IRedisUpdateParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IRedisUpdateProperties _properties;

        /// <summary>Redis cache properties.</summary>
        public Sample.API.Models.IRedisUpdateProperties Properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        /// <summary>Backing field for Tags property</summary>
        private System.Collections.Generic.IDictionary<string,string> _tags;

        /// <summary>Resource tags.</summary>
        public System.Collections.Generic.IDictionary<string,string> Tags
        {
            get
            {
                return this._tags;
            }
            set
            {
                this._tags = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisUpdateParameters" /> instance.</summary>
        public RedisUpdateParameters()
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
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// Parameters supplied to the Update Redis operation.
    public partial interface IRedisUpdateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IRedisUpdateProperties Properties { get; set; }
        System.Collections.Generic.IDictionary<string,string> Tags { get; set; }
    }
}