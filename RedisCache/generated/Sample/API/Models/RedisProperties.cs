namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Properties of the redis cache.</summary>
    public partial class RedisProperties : Sample.API.Models.IRedisProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="RedisProperties" /></summary>
        private Sample.API.Models.IRedisCreateProperties _redisCreateProperties = new Sample.API.Models.RedisCreateProperties();
        /// <summary>Backing field for AccessKeys property</summary>
        private Sample.API.Models.IRedisAccessKeys _accessKeys;

        /// <summary>
        /// The keys of the Redis cache - not set if this object is not the response to Create or Update redis cache
        /// </summary>
        public Sample.API.Models.IRedisAccessKeys AccessKeys
        {
            get
            {
                return this._accessKeys;
            }
            set
            {
                this._accessKeys = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public bool? EnableNonSslPort
        {
            get
            {
                return _redisCreateProperties.EnableNonSslPort;
            }
            set
            {
                _redisCreateProperties.EnableNonSslPort = value;
            }
        }
        /// <summary>Backing field for HostName property</summary>
        private string _hostName;

        /// <summary>Redis host name.</summary>
        public string HostName
        {
            get
            {
                return this._hostName;
            }
            internal set
            {
                this._hostName = value;
            }
        }
        /// <summary>Backing field for LinkedServers property</summary>
        private Sample.API.Models.IRedisLinkedServer[] _linkedServers;

        /// <summary>List of the linked servers associated with the cache</summary>
        public Sample.API.Models.IRedisLinkedServer[] LinkedServers
        {
            get
            {
                return this._linkedServers;
            }
            internal set
            {
                this._linkedServers = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public Sample.API.Support.TlsVersion MinimumTlsVersion
        {
            get
            {
                return _redisCreateProperties.MinimumTlsVersion;
            }
            set
            {
                _redisCreateProperties.MinimumTlsVersion = value;
            }
        }
        /// <summary>Backing field for Port property</summary>
        private int? _port;

        /// <summary>Redis non-SSL port.</summary>
        public int? Port
        {
            get
            {
                return this._port;
            }
            internal set
            {
                this._port = value;
            }
        }
        /// <summary>Backing field for ProvisioningState property</summary>
        private Sample.API.Support.ProvisioningState _provisioningState;

        /// <summary>Redis instance provisioning status.</summary>
        public Sample.API.Support.ProvisioningState ProvisioningState
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
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> RedisConfiguration
        {
            get
            {
                return _redisCreateProperties.RedisConfiguration;
            }
            set
            {
                _redisCreateProperties.RedisConfiguration = value;
            }
        }
        /// <summary>Backing field for RedisVersion property</summary>
        private string _redisVersion;

        /// <summary>Redis version.</summary>
        public string RedisVersion
        {
            get
            {
                return this._redisVersion;
            }
            internal set
            {
                this._redisVersion = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public int? ShardCount
        {
            get
            {
                return _redisCreateProperties.ShardCount;
            }
            set
            {
                _redisCreateProperties.ShardCount = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public Sample.API.Models.ISku Sku
        {
            get
            {
                return _redisCreateProperties.Sku;
            }
            set
            {
                _redisCreateProperties.Sku = value;
            }
        }
        /// <summary>Backing field for SslPort property</summary>
        private int? _sslPort;

        /// <summary>Redis SSL port.</summary>
        public int? SslPort
        {
            get
            {
                return this._sslPort;
            }
            internal set
            {
                this._sslPort = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public string StaticIP
        {
            get
            {
                return _redisCreateProperties.StaticIP;
            }
            set
            {
                _redisCreateProperties.StaticIP = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public string SubnetId
        {
            get
            {
                return _redisCreateProperties.SubnetId;
            }
            set
            {
                _redisCreateProperties.SubnetId = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IRedisCreateProperties" /> - Properties supplied to Create Redis operation.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> TenantSettings
        {
            get
            {
                return _redisCreateProperties.TenantSettings;
            }
            set
            {
                _redisCreateProperties.TenantSettings = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisProperties" /> instance.</summary>
        public RedisProperties()
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
            await eventListener.AssertNotNull(nameof(_redisCreateProperties), _redisCreateProperties);
            await eventListener.AssertObjectIsValid(nameof(_redisCreateProperties), _redisCreateProperties);
            await eventListener.AssertObjectIsValid(nameof(AccessKeys), AccessKeys);
            if (LinkedServers != null ) {
                    for (int __i = 0; __i < LinkedServers.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"LinkedServers[{__i}]", LinkedServers[__i]);
                    }
                  }
            await eventListener.AssertEnum(nameof(ProvisioningState),ProvisioningState,@"Creating", @"Deleting", @"Disabled", @"Failed", @"Linking", @"Provisioning", @"RecoveringScaleFailure", @"Scaling", @"Succeeded", @"Unlinking", @"Unprovisioning", @"Updating");
        }
    }
    /// Properties of the redis cache.
    public partial interface IRedisProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IRedisCreateProperties {
        Sample.API.Models.IRedisAccessKeys AccessKeys { get; set; }
        string HostName { get;  }
        Sample.API.Models.IRedisLinkedServer[] LinkedServers { get;  }
        int? Port { get;  }
        Sample.API.Support.ProvisioningState ProvisioningState { get;  }
        string RedisVersion { get;  }
        int? SslPort { get;  }
    }
}