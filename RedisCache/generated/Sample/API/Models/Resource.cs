namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The Resource definition.</summary>
    public partial class Resource : Sample.API.Models.IResource
    {
        /// <summary>Backing field for Id property</summary>
        private string _id;

        /// <summary>Resource ID.</summary>
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
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Resource name.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            internal set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Type property</summary>
        private string _type;

        /// <summary>Resource type.</summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            internal set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {
        }
    }
    /// The Resource definition.
    public partial interface IResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Id { get;  }
        string Name { get;  }
        string Type { get;  }
    }
}