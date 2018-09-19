namespace Sample.API.Support
{

    public struct SkuName : System.IEquatable<SkuName>
    {
        public static Sample.API.Support.SkuName Basic = @"Basic";
        public static Sample.API.Support.SkuName Premium = @"Premium";
        public static Sample.API.Support.SkuName Standard = @"Standard";
        /// <summary>the value for an instance of the <see cref="SkuName" /> Enum.</summary>
        private string _value {get;set;}
        /// <summary>Compares values of enum type SkuName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Sample.API.Support.SkuName e)
        {
            return _value.Equals(e._value);
        }
        /// <summary>Compares values of enum type SkuName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SkuName && Equals((SkuName)obj);
        }
        /// <summary>Returns hashCode for enum SkuName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }
        /// <summary>Creates an instance of the <see cref="SkuName" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SkuName(string underlyingValue)
        {
            this._value = underlyingValue;
        }
        /// <summary>Returns string representation for SkuName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }
        /// <summary>Implicit operator to convert string to SkuName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SkuName" />.</param>
        public static implicit operator SkuName(string value)
        {
            return new SkuName(value);
        }
        /// <summary>Implicit operator to convert SkuName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SkuName" />.</param>
        public static implicit operator string(Sample.API.Support.SkuName e)
        {
            return e._value;
        }
        /// <summary>Overriding != operator for enum SkuName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Sample.API.Support.SkuName e1, Sample.API.Support.SkuName e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum SkuName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Sample.API.Support.SkuName e1, Sample.API.Support.SkuName e2)
        {
            return e2.Equals(e1);
        }
    }
}