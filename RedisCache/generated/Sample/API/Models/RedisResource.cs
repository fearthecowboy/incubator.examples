namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>A single Redis item in List or Get Operation.</summary>
    public partial class RedisResource : Sample.API.Models.IRedisResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="RedisResource" /></summary>
        private Sample.API.Models.ITrackedResource _trackedResource = new Sample.API.Models.TrackedResource();
        /// <summary>
        /// Inherited model <see cref="ITrackedResource" /> - The resource model definition for a ARM tracked top level resource
        /// </summary>
        public string Id
        {
            get
            {
                return _trackedResource.Id;
            }
        }
        /// <summary>
        /// Inherited model <see cref="ITrackedResource" /> - The resource model definition for a ARM tracked top level resource
        /// </summary>
        public string Location
        {
            get
            {
                return _trackedResource.Location;
            }
            set
            {
                _trackedResource.Location = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="ITrackedResource" /> - The resource model definition for a ARM tracked top level resource
        /// </summary>
        public string Name
        {
            get
            {
                return _trackedResource.Name;
            }
        }
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IRedisProperties _properties;

        /// <summary>Redis cache properties.</summary>
        public Sample.API.Models.IRedisProperties Properties
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
        /// <summary>
        /// Inherited model <see cref="ITrackedResource" /> - The resource model definition for a ARM tracked top level resource
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> Tags
        {
            get
            {
                return _trackedResource.Tags;
            }
            set
            {
                _trackedResource.Tags = value;
            }
        }
        /// <summary>
        /// Inherited model <see cref="ITrackedResource" /> - The resource model definition for a ARM tracked top level resource
        /// </summary>
        public string Type
        {
            get
            {
                return _trackedResource.Type;
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
        /// <summary>Creates an new <see cref="RedisResource" /> instance.</summary>
        public RedisResource()
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
            await eventListener.AssertNotNull(nameof(_trackedResource), _trackedResource);
            await eventListener.AssertObjectIsValid(nameof(_trackedResource), _trackedResource);
            await eventListener.AssertNotNull(nameof(Properties), Properties);
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// A single Redis item in List or Get Operation.
    public partial interface IRedisResource : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.ITrackedResource {
        Sample.API.Models.IRedisProperties Properties { get; set; }
        string[] Zones { get; set; }
    }
}