namespace Sample.API.Support
{

    public struct DayOfWeek : System.IEquatable<DayOfWeek>
    {
        public static Sample.API.Support.DayOfWeek Everyday = @"Everyday";
        public static Sample.API.Support.DayOfWeek Friday = @"Friday";
        public static Sample.API.Support.DayOfWeek Monday = @"Monday";
        public static Sample.API.Support.DayOfWeek Saturday = @"Saturday";
        public static Sample.API.Support.DayOfWeek Sunday = @"Sunday";
        public static Sample.API.Support.DayOfWeek Thursday = @"Thursday";
        public static Sample.API.Support.DayOfWeek Tuesday = @"Tuesday";
        public static Sample.API.Support.DayOfWeek Wednesday = @"Wednesday";
        public static Sample.API.Support.DayOfWeek Weekend = @"Weekend";
        /// <summary>the value for an instance of the <see cref="DayOfWeek" /> Enum.</summary>
        private string _value {get;set;}
        /// <summary>Creates an instance of the <see cref="DayOfWeek" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DayOfWeek(string underlyingValue)
        {
            this._value = underlyingValue;
        }
        /// <summary>Compares values of enum type DayOfWeek</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Sample.API.Support.DayOfWeek e)
        {
            return _value.Equals(e._value);
        }
        /// <summary>Compares values of enum type DayOfWeek (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DayOfWeek && Equals((DayOfWeek)obj);
        }
        /// <summary>Returns hashCode for enum DayOfWeek</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }
        /// <summary>Returns string representation for DayOfWeek</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }
        /// <summary>Implicit operator to convert string to DayOfWeek</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DayOfWeek" />.</param>
        public static implicit operator DayOfWeek(string value)
        {
            return new DayOfWeek(value);
        }
        /// <summary>Implicit operator to convert DayOfWeek to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DayOfWeek" />.</param>
        public static implicit operator string(Sample.API.Support.DayOfWeek e)
        {
            return e._value;
        }
        /// <summary>Overriding != operator for enum DayOfWeek</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Sample.API.Support.DayOfWeek e1, Sample.API.Support.DayOfWeek e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum DayOfWeek</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Sample.API.Support.DayOfWeek e1, Sample.API.Support.DayOfWeek e2)
        {
            return e2.Equals(e1);
        }
    }
}