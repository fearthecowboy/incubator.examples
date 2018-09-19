namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Properties of upgrade notification.</summary>
    public partial class UpgradeNotification : Sample.API.Models.IUpgradeNotification
    {
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Name of upgrade notification.</summary>
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
        /// <summary>Backing field for Timestamp property</summary>
        private System.DateTime? _timestamp;

        /// <summary>Timestamp when upgrade notification occured.</summary>
        public System.DateTime? Timestamp
        {
            get
            {
                return this._timestamp;
            }
            internal set
            {
                this._timestamp = value;
            }
        }
        /// <summary>Backing field for UpsellNotification property</summary>
        private System.Collections.Generic.IDictionary<string,string> _upsellNotification;

        /// <summary>Details about this upgrade notification</summary>
        public System.Collections.Generic.IDictionary<string,string> UpsellNotification
        {
            get
            {
                return this._upsellNotification;
            }
            internal set
            {
                this._upsellNotification = value;
            }
        }
        /// <summary>Creates an new <see cref="UpgradeNotification" /> instance.</summary>
        public UpgradeNotification()
        {
        }
    }
    /// Properties of upgrade notification.
    public partial interface IUpgradeNotification : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Name { get;  }
        System.DateTime? Timestamp { get;  }
        System.Collections.Generic.IDictionary<string,string> UpsellNotification { get;  }
    }
}