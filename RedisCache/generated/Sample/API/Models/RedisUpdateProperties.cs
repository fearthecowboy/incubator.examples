namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Patchable properties of the redis cache.</summary>
    public partial class RedisUpdateProperties : Sample.API.Models.IRedisUpdateProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="RedisUpdateProperties" /></summary>
        private Sample.API.Models.IRedisCommonProperties _redisCommonProperties = new Sample.API.Models.RedisCommonProperties();
        /// <summary>
        /// Inherited model <see cref="IRedisCommonProperties" /> - Create/Update/Get common properties of the redis cache.
        /// </summary>
        public bool? EnableNonSslPort
        {
            get
            {
                return _redisCommonProperties.EnableNonSslPort;
            }
            set
            {
                _redisCommonProperties.EnableNonSslPort = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCommonProperties" /> - Create/Update/Get common properties of the redis cache.
        /// </summary>
        public Sample.API.Support.TlsVersion MinimumTlsVersion
        {
            get
            {
                return _redisCommonProperties.MinimumTlsVersion;
            }
            set
            {
                _redisCommonProperties.MinimumTlsVersion = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCommonProperties" /> - Create/Update/Get common properties of the redis cache.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> RedisConfiguration
        {
            get
            {
                return _redisCommonProperties.RedisConfiguration;
            }
            set
            {
                _redisCommonProperties.RedisConfiguration = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCommonProperties" /> - Create/Update/Get common properties of the redis cache.
        /// </summary>
        public int? ShardCount
        {
            get
            {
                return _redisCommonProperties.ShardCount;
            }
            set
            {
                _redisCommonProperties.ShardCount = value;
            }
        }
        /// <summary>Backing field for Sku property</summary>
        private Sample.API.Models.ISku _sku;

        /// <summary>The SKU of the Redis cache to deploy.</summary>
        public Sample.API.Models.ISku Sku
        {
            get
            {
                return this._sku;
            }
            set
            {
                this._sku = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCommonProperties" /> - Create/Update/Get common properties of the redis cache.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> TenantSettings
        {
            get
            {
                return _redisCommonProperties.TenantSettings;
            }
            set
            {
                _redisCommonProperties.TenantSettings = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisUpdateProperties" /> instance.</summary>
        public RedisUpdateProperties()
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
            await eventListener.AssertNotNull(nameof(_redisCommonProperties), _redisCommonProperties);
            await eventListener.AssertObjectIsValid(nameof(_redisCommonProperties), _redisCommonProperties);
            await eventListener.AssertObjectIsValid(nameof(Sku), Sku);
        }
    }
    /// Patchable properties of the redis cache.
    public partial interface IRedisUpdateProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IRedisCommonProperties {
        Sample.API.Models.ISku Sku { get; set; }
    }
}