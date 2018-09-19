namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Parameters required for creating a firewall rule on redis cache.</summary>
    public partial class RedisFirewallRuleCreateParameters : Sample.API.Models.IRedisFirewallRuleCreateParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IRedisFirewallRuleProperties _properties;

        /// <summary>Properties required to create a firewall rule .</summary>
        public Sample.API.Models.IRedisFirewallRuleProperties Properties
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
        /// <summary>Creates an new <see cref="RedisFirewallRuleCreateParameters" /> instance.</summary>
        public RedisFirewallRuleCreateParameters()
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
    /// Parameters required for creating a firewall rule on redis cache.
    public partial interface IRedisFirewallRuleCreateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IRedisFirewallRuleProperties Properties { get; set; }
    }
}