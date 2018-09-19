namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Specifies which Redis access keys to reset.</summary>
    public partial class RedisRegenerateKeyParameters : Sample.API.Models.IRedisRegenerateKeyParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for KeyType property</summary>
        private Sample.API.Support.RedisKeyType _keyType;

        /// <summary>The Redis access key to regenerate.</summary>
        public Sample.API.Support.RedisKeyType KeyType
        {
            get
            {
                return this._keyType;
            }
            set
            {
                this._keyType = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisRegenerateKeyParameters" /> instance.</summary>
        public RedisRegenerateKeyParameters()
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
            await eventListener.AssertNotNull(nameof(KeyType),KeyType);
            await eventListener.AssertEnum(nameof(KeyType),KeyType,@"Primary", @"Secondary");
        }
    }
    /// Specifies which Redis access keys to reset.
    public partial interface IRedisRegenerateKeyParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Support.RedisKeyType KeyType { get; set; }
    }
}