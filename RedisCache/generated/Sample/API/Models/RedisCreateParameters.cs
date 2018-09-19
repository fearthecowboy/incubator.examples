namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Parameters supplied to the Create Redis operation.</summary>
    public partial class RedisCreateParameters : Sample.API.Models.IRedisCreateParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Location property</summary>
        private string _location;

        /// <summary>The geo-location where the resource lives</summary>
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IRedisCreateProperties _properties;

        /// <summary>Redis cache properties.</summary>
        public Sample.API.Models.IRedisCreateProperties Properties
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
        /// <summary>Backing field for Tags property</summary>
        private System.Collections.Generic.IDictionary<string,string> _tags;

        /// <summary>Resource tags.</summary>
        public System.Collections.Generic.IDictionary<string,string> Tags
        {
            get
            {
                return this._tags;
            }
            set
            {
                this._tags = value;
            }
        }
        /// <summary>Backing field for Zones property</summary>
        private string[] _zones;

        /// <summary>A list of availability zones denoting where the resource needs to come from.</summary>
        public string[] Zones
        {
            get
            {
                return this._zones;
            }
            set
            {
                this._zones = value;
            }
        }
        /// <summary>Creates an new <see cref="RedisCreateParameters" /> instance.</summary>
        public RedisCreateParameters()
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
            await eventListener.AssertNotNull(nameof(Location),Location);
            await eventListener.AssertNotNull(nameof(Properties), Properties);
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// Parameters supplied to the Create Redis operation.
    public partial interface IRedisCreateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Location { get; set; }
        Sample.API.Models.IRedisCreateProperties Properties { get; set; }
        System.Collections.Generic.IDictionary<string,string> Tags { get; set; }
        string[] Zones { get; set; }
    }
}