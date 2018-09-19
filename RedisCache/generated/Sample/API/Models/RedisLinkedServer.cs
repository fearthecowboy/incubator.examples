namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Linked server Id</summary>
    public partial class RedisLinkedServer : Sample.API.Models.IRedisLinkedServer
    {
        /// <summary>Backing field for Id property</summary>
        private string _id;

        /// <summary>Linked server Id.</summary>
        public string Id
        {
            get
            {
                return this._id;
            }
            internal set
            {
                this._id = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisLinkedServer" /> instance.</summary>
        public RedisLinkedServer()
        {
        }
    }
    /// Linked server Id
    public partial interface IRedisLinkedServer : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Id { get;  }
    }
}