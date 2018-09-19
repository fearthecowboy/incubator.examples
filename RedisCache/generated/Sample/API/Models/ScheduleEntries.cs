namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>List of patch schedules for a Redis cache.</summary>
    public partial class ScheduleEntries : Sample.API.Models.IScheduleEntries, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ScheduleEntriesProperty property</summary>
        private Sample.API.Models.IScheduleEntry[] _scheduleEntriesProperty;

        /// <summary>List of patch schedules for a Redis cache.</summary>
        public Sample.API.Models.IScheduleEntry[] ScheduleEntriesProperty
        {
            get
            {
                return this._scheduleEntriesProperty;
            }
            set
            {
                this._scheduleEntriesProperty = value;
            }
        }
        /// <summary>Creates an new <see cref="ScheduleEntries" /> instance.</summary>
        public ScheduleEntries()
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
            await eventListener.AssertNotNull(nameof(ScheduleEntriesProperty), ScheduleEntriesProperty);
            if (ScheduleEntriesProperty != null ) {
                    for (int __i = 0; __i < ScheduleEntriesProperty.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"ScheduleEntriesProperty[{__i}]", ScheduleEntriesProperty[__i]);
                    }
                  }
        }
    }
    /// List of patch schedules for a Redis cache.
    public partial interface IScheduleEntries : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IScheduleEntry[] ScheduleEntriesProperty { get; set; }
    }
}