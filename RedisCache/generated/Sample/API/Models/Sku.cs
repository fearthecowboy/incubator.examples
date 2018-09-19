namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>SKU parameters supplied to the create Redis operation.</summary>
    public partial class Sku : Sample.API.Models.ISku, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Capacity property</summary>
        private int _capacity;

        /// <summary>
        /// The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium)
        /// family (1, 2, 3, 4).
        /// </summary>
        public int Capacity
        {
            get
            {
                return this._capacity;
            }
            set
            {
                this._capacity = value;
            }
        }
        /// <summary>Backing field for Family property</summary>
        private Sample.API.Support.SkuFamily _family;

        /// <summary>The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium).</summary>
        public Sample.API.Support.SkuFamily Family
        {
            get
            {
                return this._family;
            }
            set
            {
                this._family = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private Sample.API.Support.SkuName _name;

        /// <summary>The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium)</summary>
        public Sample.API.Support.SkuName Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Creates an new <see cref="Sku" /> instance.</summary>
        public Sku()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertEnum(nameof(Name),Name,@"Basic", @"Standard", @"Premium");
            await eventListener.AssertNotNull(nameof(Family),Family);
            await eventListener.AssertEnum(nameof(Family),Family,@"C", @"P");
        }
    }
    /// SKU parameters supplied to the create Redis operation.
    public partial interface ISku : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int Capacity { get; set; }
        Sample.API.Support.SkuFamily Family { get; set; }
        Sample.API.Support.SkuName Name { get; set; }
    }
}