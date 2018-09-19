namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response to put/get patch schedules for Redis cache.</summary>
    public partial class RedisPatchSchedule : Sample.API.Models.IRedisPatchSchedule, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="RedisPatchSchedule" /></summary>
        private Sample.API.Models.IProxyResource _proxyResource = new Sample.API.Models.ProxyResource();
        /// <summary>
        /// Inherited model <see cref="IProxyResource" /> - The resource model definition for a ARM proxy resource. It will have everything
        /// other than required location and tags
        /// </summary>
        public string Id
        {
            get
            {
                return _proxyResource.Id;
            }
        }
        /// <summary>
        /// Inherited model <see cref="IProxyResource" /> - The resource model definition for a ARM proxy resource. It will have everything
        /// other than required location and tags
        /// </summary>
        public string Name
        {
            get
            {
                return _proxyResource.Name;
            }
        }
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IScheduleEntries _properties;

        /// <summary>List of patch schedules for a Redis cache.</summary>
        public Sample.API.Models.IScheduleEntries Properties
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
        /// Inherited model <see cref="IProxyResource" /> - The resource model definition for a ARM proxy resource. It will have everything
        /// other than required location and tags
        /// </summary>
        public string Type
        {
            get
            {
                return _proxyResource.Type;
            }
        }
        /// <summary>Creates an new <see cref="RedisPatchSchedule" /> instance.</summary>
        public RedisPatchSchedule()
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
            await eventListener.AssertNotNull(nameof(_proxyResource), _proxyResource);
            await eventListener.AssertObjectIsValid(nameof(_proxyResource), _proxyResource);
            await eventListener.AssertNotNull(nameof(Properties), Properties);
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// Response to put/get patch schedules for Redis cache.
    public partial interface IRedisPatchSchedule : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IProxyResource {
        Sample.API.Models.IScheduleEntries Properties { get; set; }
    }
}