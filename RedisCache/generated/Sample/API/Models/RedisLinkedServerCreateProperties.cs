namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Create properties for a linked server</summary>
    public partial class RedisLinkedServerCreateProperties : Sample.API.Models.IRedisLinkedServerCreateProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for LinkedRedisCacheId property</summary>
        private string _linkedRedisCacheId;

        /// <summary>Fully qualified resourceId of the linked redis cache.</summary>
        public string LinkedRedisCacheId
        {
            get
            {
                return this._linkedRedisCacheId;
            }
            set
            {
                this._linkedRedisCacheId = value;
            }
        }
        /// <summary>Backing field for LinkedRedisCacheLocation property</summary>
        private string _linkedRedisCacheLocation;

        /// <summary>Location of the linked redis cache.</summary>
        public string LinkedRedisCacheLocation
        {
            get
            {
                return this._linkedRedisCacheLocation;
            }
            set
            {
                this._linkedRedisCacheLocation = value;
            }
        }
        /// <summary>Backing field for ServerRole property</summary>
        private Sample.API.Support.ReplicationRole _serverRole;

        /// <summary>Role of the linked server.</summary>
        public Sample.API.Support.ReplicationRole ServerRole
        {
            get
            {
                return this._serverRole;
            }
            set
            {
                this._serverRole = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisLinkedServerCreateProperties" /> instance.</summary>
        public RedisLinkedServerCreateProperties()
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
            await eventListener.AssertNotNull(nameof(LinkedRedisCacheId),LinkedRedisCacheId);
            await eventListener.AssertNotNull(nameof(LinkedRedisCacheLocation),LinkedRedisCacheLocation);
            await eventListener.AssertNotNull(nameof(ServerRole),ServerRole);
            await eventListener.AssertEnum(nameof(ServerRole),ServerRole,@"Primary", @"Secondary");
        }
    }
    /// Create properties for a linked server
    public partial interface IRedisLinkedServerCreateProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string LinkedRedisCacheId { get; set; }
        string LinkedRedisCacheLocation { get; set; }
        Sample.API.Support.ReplicationRole ServerRole { get; set; }
    }
}