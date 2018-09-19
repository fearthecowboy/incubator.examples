namespace Sample.API.Support
{

    public struct RedisKeyType : System.IEquatable<RedisKeyType>
    {
        public static Sample.API.Support.RedisKeyType Primary = @"Primary";
        public static Sample.API.Support.RedisKeyType Secondary = @"Secondary";
        /// <summary>the value for an instance of the <see cref="RedisKeyType" /> Enum.</summary>
        private string _value {get;set;}
        /// <summary>Compares values of enum type RedisKeyType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Sample.API.Support.RedisKeyType e)
        {
            return _value.Equals(e._value);
        }
        /// <summary>Compares values of enum type RedisKeyType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RedisKeyType && Equals((RedisKeyType)obj);
        }
        /// <summary>Returns hashCode for enum RedisKeyType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }
        /// <summary>Creates an instance of the <see cref="RedisKeyType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RedisKeyType(string underlyingValue)
        {
            this._value = underlyingValue;
        }
        /// <summary>Returns string representation for RedisKeyType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }
        /// <summary>Implicit operator to convert string to RedisKeyType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RedisKeyType" />.</param>
        public static implicit operator RedisKeyType(string value)
        {
            return new RedisKeyType(value);
        }
        /// <summary>Implicit operator to convert RedisKeyType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RedisKeyType" />.</param>
        public static implicit operator string(Sample.API.Support.RedisKeyType e)
        {
            return e._value;
        }
        /// <summary>Overriding != operator for enum RedisKeyType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Sample.API.Support.RedisKeyType e1, Sample.API.Support.RedisKeyType e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum RedisKeyType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Sample.API.Support.RedisKeyType e1, Sample.API.Support.RedisKeyType e2)
        {
            return e2.Equals(e1);
        }
    }
}