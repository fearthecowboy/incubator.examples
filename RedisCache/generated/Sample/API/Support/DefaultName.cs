namespace Sample.API.Support
{

    public struct DefaultName : System.IEquatable<DefaultName>
    {
        public static Sample.API.Support.DefaultName Default = @"default";
        /// <summary>the value for an instance of the <see cref="DefaultName" /> Enum.</summary>
        private string _value {get;set;}
        /// <summary>Creates an instance of the <see cref="DefaultName" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DefaultName(string underlyingValue)
        {
            this._value = underlyingValue;
        }
        /// <summary>Compares values of enum type DefaultName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Sample.API.Support.DefaultName e)
        {
            return _value.Equals(e._value);
        }
        /// <summary>Compares values of enum type DefaultName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DefaultName && Equals((DefaultName)obj);
        }
        /// <summary>Returns hashCode for enum DefaultName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }
        /// <summary>Returns string representation for DefaultName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }
        /// <summary>Implicit operator to convert string to DefaultName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DefaultName" />.</param>
        public static implicit operator DefaultName(string value)
        {
            return new DefaultName(value);
        }
        /// <summary>Implicit operator to convert DefaultName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DefaultName" />.</param>
        public static implicit operator string(Sample.API.Support.DefaultName e)
        {
            return e._value;
        }
        /// <summary>Overriding != operator for enum DefaultName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Sample.API.Support.DefaultName e1, Sample.API.Support.DefaultName e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum DefaultName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Sample.API.Support.DefaultName e1, Sample.API.Support.DefaultName e2)
        {
            return e2.Equals(e1);
        }
    }
}