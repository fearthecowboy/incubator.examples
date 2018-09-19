namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The resource model definition for a ARM proxy resource. It will have everything other than required location and tags
    /// </summary>
    public partial class ProxyResource : Sample.API.Models.IProxyResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ProxyResource" /></summary>
        private Sample.API.Models.IResource _resource = new Sample.API.Models.Resource();
        /// <summary>Inherited model <see cref="IResource" /> - The Resource definition.</summary>
        public string Id
        {
            get
            {
                return _resource.Id;
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
        /// <summary>Inherited model <see cref="IResource" /> - The Resource definition.</summary>
        public string Type
        {
            get
            {
                return _resource.Type;
            }
        }
        /// <summary>Creates an new <see cref="ProxyResource" /> instance.</summary>
        public ProxyResource()
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
        }
    }
    /// The resource model definition for a ARM proxy resource. It will have everything other than required location and tags
    public partial interface IProxyResource : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IResource {

    }
}