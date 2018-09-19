namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Redis cache access keys.</summary>
    public partial class RedisAccessKeys : Sample.API.Models.IRedisAccessKeys
    {
        /// <summary>Backing field for PrimaryKey property</summary>
        private string _primaryKey;

        /// <summary>The current primary key that clients can use to authenticate with Redis cache.</summary>
        public string PrimaryKey
        {
            get
            {
                return this._primaryKey;
            }
            internal set
            {
                this._primaryKey = value;
            }
        }
        /// <summary>Backing field for SecondaryKey property</summary>
        private string _secondaryKey;

        /// <summary>
        /// The current secondary key that clients can use to authenticate with Redis cache.
        /// </summary>
        public string SecondaryKey
        {
            get
            {
                return this._secondaryKey;
            }
            internal set
            {
                this._secondaryKey = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisAccessKeys" /> instance.</summary>
        public RedisAccessKeys()
        {
        }
    }
    /// Redis cache access keys.
    public partial interface IRedisAccessKeys : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string PrimaryKey { get;  }
        string SecondaryKey { get;  }
    }
}