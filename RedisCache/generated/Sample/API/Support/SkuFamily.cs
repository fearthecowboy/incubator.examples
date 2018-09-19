namespace Sample.API.Support
{

    public struct SkuFamily : System.IEquatable<SkuFamily>
    {
        public static Sample.API.Support.SkuFamily C = @"C";
        public static Sample.API.Support.SkuFamily P = @"P";
        /// <summary>the value for an instance of the <see cref="SkuFamily" /> Enum.</summary>
        private string _value {get;set;}
        /// <summary>Compares values of enum type SkuFamily</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Sample.API.Support.SkuFamily e)
        {
            return _value.Equals(e._value);
        }
        /// <summary>Compares values of enum type SkuFamily (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SkuFamily && Equals((SkuFamily)obj);
        }
        /// <summary>Returns hashCode for enum SkuFamily</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }
        /// <summary>Creates an instance of the <see cref="SkuFamily" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SkuFamily(string underlyingValue)
        {
            this._value = underlyingValue;
        }
        /// <summary>Returns string representation for SkuFamily</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }
        /// <summary>Implicit operator to convert string to SkuFamily</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SkuFamily" />.</param>
        public static implicit operator SkuFamily(string value)
        {
            return new SkuFamily(value);
        }
        /// <summary>Implicit operator to convert SkuFamily to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SkuFamily" />.</param>
        public static implicit operator string(Sample.API.Support.SkuFamily e)
        {
            return e._value;
        }
        /// <summary>Overriding != operator for enum SkuFamily</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Sample.API.Support.SkuFamily e1, Sample.API.Support.SkuFamily e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum SkuFamily</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Sample.API.Support.SkuFamily e1, Sample.API.Support.SkuFamily e2)
        {
            return e2.Equals(e1);
        }
    }
}