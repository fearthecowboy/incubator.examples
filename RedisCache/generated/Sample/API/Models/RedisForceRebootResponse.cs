namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response to force reboot for Redis cache.</summary>
    public partial class RedisForceRebootResponse : Sample.API.Models.IRedisForceRebootResponse
    {
        /// <summary>Backing field for Message property</summary>
        private string _message;

        /// <summary>Status message</summary>
        public string Message
        {
            get
            {
                return this._message;
            }
            internal set
            {
                this._message = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisForceRebootResponse" /> instance.</summary>
        public RedisForceRebootResponse()
        {
        }
    }
    /// Response to force reboot for Redis cache.
    public partial interface IRedisForceRebootResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Message { get;  }
    }
}