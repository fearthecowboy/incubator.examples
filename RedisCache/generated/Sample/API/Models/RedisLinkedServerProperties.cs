namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Properties of a linked server to be returned in get/put response</summary>
    public partial class RedisLinkedServerProperties : Sample.API.Models.IRedisLinkedServerProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="RedisLinkedServerProperties" /></summary>
        private Sample.API.Models.IRedisLinkedServerCreateProperties _redisLinkedServerCreateProperties = new Sample.API.Models.RedisLinkedServerCreateProperties();
        /// <summary>
        /// Inherited model <see cref="IRedisLinkedServerCreateProperties" /> - Create properties for a linked server
        /// </summary>
        public string LinkedRedisCacheId
        {
            get
            {
                return _redisLinkedServerCreateProperties.LinkedRedisCacheId;
            }
            set
            {
                _redisLinkedServerCreateProperties.LinkedRedisCacheId = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisLinkedServerCreateProperties" /> - Create properties for a linked server
        /// </summary>
        public string LinkedRedisCacheLocation
        {
            get
            {
                return _redisLinkedServerCreateProperties.LinkedRedisCacheLocation;
            }
            set
            {
                _redisLinkedServerCreateProperties.LinkedRedisCacheLocation = value;
            }
        }
        /// <summary>Backing field for ProvisioningState property</summary>
        private string _provisioningState;

        /// <summary>Terminal state of the link between primary and secondary redis cache.</summary>
        public string ProvisioningState
        {
            get
            {
                return this._provisioningState;
            }
            internal set
            {
                this._provisioningState = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisLinkedServerCreateProperties" /> - Create properties for a linked server
        /// </summary>
        public Sample.API.Support.ReplicationRole ServerRole
        {
            get
            {
                return _redisLinkedServerCreateProperties.ServerRole;
            }
            set
            {
                _redisLinkedServerCreateProperties.ServerRole = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisLinkedServerProperties" /> instance.</summary>
        public RedisLinkedServerProperties()
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
            await eventListener.AssertNotNull(nameof(_redisLinkedServerCreateProperties), _redisLinkedServerCreateProperties);
            await eventListener.AssertObjectIsValid(nameof(_redisLinkedServerCreateProperties), _redisLinkedServerCreateProperties);
        }
    }
    /// Properties of a linked server to be returned in get/put response
    public partial interface IRedisLinkedServerProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IRedisLinkedServerCreateProperties {
        string ProvisioningState { get;  }
    }
}