// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Certificate product type.</summary>
    public partial struct CertificateProductType :
        System.IEquatable<CertificateProductType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType StandardDomainValidatedSsl = @"StandardDomainValidatedSsl";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType StandardDomainValidatedWildCardSsl = @"StandardDomainValidatedWildCardSsl";

        /// <summary>the value for an instance of the <see cref="CertificateProductType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="CertificateProductType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CertificateProductType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to CertificateProductType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CertificateProductType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new CertificateProductType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type CertificateProductType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type CertificateProductType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CertificateProductType && Equals((CertificateProductType)obj);
        }

        /// <summary>Returns hashCode for enum CertificateProductType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for CertificateProductType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to CertificateProductType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CertificateProductType" />.</param>

        public static implicit operator CertificateProductType(string value)
        {
            return new CertificateProductType(value);
        }

        /// <summary>Implicit operator to convert CertificateProductType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="CertificateProductType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum CertificateProductType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum CertificateProductType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.CertificateProductType e2)
        {
            return e2.Equals(e1);
        }
    }
}