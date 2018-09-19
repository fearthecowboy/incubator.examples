namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The resource model definition for a ARM tracked top level resource</summary>
    public partial class TrackedResource : Sample.API.Models.ITrackedResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="TrackedResource" /></summary>
        private Sample.API.Models.IResource _resource = new Sample.API.Models.Resource();
        /// <summary>Inherited model <see cref="IResource" /> - The Resource definition.</summary>
        public string Id
        {
            get
            {
                return _resource.Id;
            }
        }
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
        /// <summary>Inherited model <see cref="IResource" /> - The Resource definition.</summary>
        public string Name
        {
            get
            {
                return _resource.Name;
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
        /// <summary>Inherited model <see cref="IResource" /> - The Resource definition.</summary>
        public string Type
        {
            get
            {
                return _resource.Type;
            }
        }
        /// <summary>Creates an new <see cref="TrackedResource" /> instance.</summary>
        public TrackedResource()
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
            await eventListener.AssertNotNull(nameof(_resource), _resource);
            await eventListener.AssertObjectIsValid(nameof(_resource), _resource);
            await eventListener.AssertNotNull(nameof(Location),Location);
        }
    }
    /// The resource model definition for a ARM tracked top level resource
    public partial interface ITrackedResource : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IResource {
        string Location { get; set; }
        System.Collections.Generic.IDictionary<string,string> Tags { get; set; }
    }
}