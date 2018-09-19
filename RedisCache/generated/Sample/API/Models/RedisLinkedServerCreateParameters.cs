namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Parameter required for creating a linked server to redis cache.</summary>
    public partial class RedisLinkedServerCreateParameters : Sample.API.Models.IRedisLinkedServerCreateParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IRedisLinkedServerCreateProperties _properties;

        /// <summary>Properties required to create a linked server.</summary>
        public Sample.API.Models.IRedisLinkedServerCreateProperties Properties
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
        /// <summary>Creates an new <see cref="RedisLinkedServerCreateParameters" /> instance.</summary>
        public RedisLinkedServerCreateParameters()
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
            await eventListener.AssertNotNull(nameof(Properties), Properties);
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// Parameter required for creating a linked server to redis cache.
    public partial interface IRedisLinkedServerCreateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IRedisLinkedServerCreateProperties Properties { get; set; }
    }
}