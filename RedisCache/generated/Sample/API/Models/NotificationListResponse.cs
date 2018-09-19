namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The response of listUpgradeNotifications.</summary>
    public partial class NotificationListResponse : Sample.API.Models.INotificationListResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for NextLink property</summary>
        private string _nextLink;

        /// <summary>Link for next set of notifications.</summary>
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
        private Sample.API.Models.IUpgradeNotification[] _value;

        /// <summary>List of all notifications.</summary>
        public Sample.API.Models.IUpgradeNotification[] Value
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
        /// <summary>Creates an new <see cref="NotificationListResponse" /> instance.</summary>
        public NotificationListResponse()
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
    /// The response of listUpgradeNotifications.
    public partial interface INotificationListResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string NextLink { get;  }
        Sample.API.Models.IUpgradeNotification[] Value { get; set; }
    }
}