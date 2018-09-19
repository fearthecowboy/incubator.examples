namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Create/Update/Get common properties of the redis cache.</summary>
    public partial class RedisCommonProperties : Sample.API.Models.IRedisCommonProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for EnableNonSslPort property</summary>
        private bool? _enableNonSslPort;

        /// <summary>Specifies whether the non-ssl Redis server port (6379) is enabled.</summary>
        public bool? EnableNonSslPort
        {
            get
            {
                return this._enableNonSslPort;
            }
            set
            {
                this._enableNonSslPort = value;
            }
        }
        /// <summary>Backing field for MinimumTlsVersion property</summary>
        private Sample.API.Support.TlsVersion _minimumTlsVersion;

        /// <summary>
        /// Optional: requires clients to use a specified TLS version (or higher) to connect (e,g, '1.0', '1.1', '1.2')
        /// </summary>
        public Sample.API.Support.TlsVersion MinimumTlsVersion
        {
            get
            {
                return this._minimumTlsVersion;
            }
            set
            {
                this._minimumTlsVersion = value;
            }
        }
        /// <summary>Backing field for RedisConfiguration property</summary>
        private System.Collections.Generic.IDictionary<string,string> _redisConfiguration;

        /// <summary>
        /// All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> RedisConfiguration
        {
            get
            {
                return this._redisConfiguration;
            }
            set
            {
                this._redisConfiguration = value;
            }
        }
        /// <summary>Backing field for ShardCount property</summary>
        private int? _shardCount;

        /// <summary>The number of shards to be created on a Premium Cluster Cache.</summary>
        public int? ShardCount
        {
            get
            {
                return this._shardCount;
            }
            set
            {
                this._shardCount = value;
            }
        }
        /// <summary>Backing field for TenantSettings property</summary>
        private System.Collections.Generic.IDictionary<string,string> _tenantSettings;

        /// <summary>A dictionary of tenant settings</summary>
        public System.Collections.Generic.IDictionary<string,string> TenantSettings
        {
            get
            {
                return this._tenantSettings;
            }
            set
            {
                this._tenantSettings = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisCommonProperties" /> instance.</summary>
        public RedisCommonProperties()
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
            await eventListener.AssertEnum(nameof(MinimumTlsVersion),MinimumTlsVersion,@"1.0", @"1.1", @"1.2");
        }
    }
    /// Create/Update/Get common properties of the redis cache.
    public partial interface IRedisCommonProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        bool? EnableNonSslPort { get; set; }
        Sample.API.Support.TlsVersion MinimumTlsVersion { get; set; }
        System.Collections.Generic.IDictionary<string,string> RedisConfiguration { get; set; }
        int? ShardCount { get; set; }
        System.Collections.Generic.IDictionary<string,string> TenantSettings { get; set; }
    }
}