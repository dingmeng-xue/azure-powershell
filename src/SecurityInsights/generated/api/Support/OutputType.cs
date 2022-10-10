// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support
{

    /// <summary>Insights Column type.</summary>
    public partial struct OutputType :
        System.IEquatable<OutputType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType Date = @"Date";

        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType Entity = @"Entity";

        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType Number = @"Number";

        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType String = @"String";

        /// <summary>the value for an instance of the <see cref="OutputType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OutputType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OutputType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OutputType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OutputType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OutputType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OutputType && Equals((OutputType)obj);
        }

        /// <summary>Returns hashCode for enum OutputType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OutputType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OutputType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OutputType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OutputType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OutputType" />.</param>

        public static implicit operator OutputType(string value)
        {
            return new OutputType(value);
        }

        /// <summary>Implicit operator to convert OutputType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OutputType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OutputType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OutputType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType e1, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.OutputType e2)
        {
            return e2.Equals(e1);
        }
    }
}