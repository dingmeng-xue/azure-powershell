// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support
{

    public partial struct ApplicationGroupType :
        System.IEquatable<ApplicationGroupType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType Desktop = @"Desktop";

        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType RemoteApp = @"RemoteApp";

        /// <summary>the value for an instance of the <see cref="ApplicationGroupType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ApplicationGroupType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ApplicationGroupType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ApplicationGroupType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ApplicationGroupType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ApplicationGroupType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ApplicationGroupType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ApplicationGroupType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ApplicationGroupType && Equals((ApplicationGroupType)obj);
        }

        /// <summary>Returns hashCode for enum ApplicationGroupType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ApplicationGroupType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ApplicationGroupType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ApplicationGroupType" />.</param>

        public static implicit operator ApplicationGroupType(string value)
        {
            return new ApplicationGroupType(value);
        }

        /// <summary>Implicit operator to convert ApplicationGroupType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ApplicationGroupType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ApplicationGroupType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ApplicationGroupType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType e1, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType e2)
        {
            return e2.Equals(e1);
        }
    }
}