namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The response of list firewall rules Redis operation.</summary>
    public partial class RedisFirewallRuleListResult : Sample.API.Models.IRedisFirewallRuleListResult, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for NextLink property</summary>
        private string _nextLink;

        /// <summary>Link for next page of results.</summary>
        public string NextLink
        {
            get
            {
                return this._nextLink;
            }
            internal set
            {
                this._nextLink = value;
            }
        }
        /// <summary>Backing field for Value property</summary>
        private Sample.API.Models.IRedisFirewallRule[] _value;

        /// <summary>Results of the list firewall rules operation.</summary>
        public Sample.API.Models.IRedisFirewallRule[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisFirewallRuleListResult" /> instance.</summary>
        public RedisFirewallRuleListResult()
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
            if (Value != null ) {
                    for (int __i = 0; __i < Value.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Value[{__i}]", Value[__i]);
                    }
                  }
        }
    }
    /// The response of list firewall rules Redis operation.
    public partial interface IRedisFirewallRuleListResult : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string NextLink { get;  }
        Sample.API.Models.IRedisFirewallRule[] Value { get; set; }
    }
}