// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support
{

    /// <summary>Controls how resources are versioned on the FHIR service</summary>
    public partial struct FhirResourceVersionPolicy :
        System.IEquatable<FhirResourceVersionPolicy>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy NoVersion = @"no-version";

        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy Versioned = @"versioned";

        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy VersionedUpdate = @"versioned-update";

        /// <summary>the value for an instance of the <see cref="FhirResourceVersionPolicy" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FhirResourceVersionPolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FhirResourceVersionPolicy" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FhirResourceVersionPolicy(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FhirResourceVersionPolicy</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FhirResourceVersionPolicy (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FhirResourceVersionPolicy && Equals((FhirResourceVersionPolicy)obj);
        }

        /// <summary>Creates an instance of the <see cref="FhirResourceVersionPolicy" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FhirResourceVersionPolicy(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FhirResourceVersionPolicy</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FhirResourceVersionPolicy</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FhirResourceVersionPolicy</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FhirResourceVersionPolicy" />.</param>

        public static implicit operator FhirResourceVersionPolicy(string value)
        {
            return new FhirResourceVersionPolicy(value);
        }

        /// <summary>Implicit operator to convert FhirResourceVersionPolicy to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FhirResourceVersionPolicy" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FhirResourceVersionPolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy e1, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FhirResourceVersionPolicy</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy e1, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.FhirResourceVersionPolicy e2)
        {
            return e2.Equals(e1);
        }
    }
}