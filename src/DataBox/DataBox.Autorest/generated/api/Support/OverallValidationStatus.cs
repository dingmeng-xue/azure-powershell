// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support
{

    /// <summary>Overall validation status.</summary>
    public partial struct OverallValidationStatus :
        System.IEquatable<OverallValidationStatus>
    {
        /// <summary>Every input request is valid.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus AllValidToProceed = @"AllValidToProceed";

        /// <summary>Certain input validations skipped.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus CertainInputValidationsSkipped = @"CertainInputValidationsSkipped";

        /// <summary>Some input requests are not valid.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus InputsRevisitRequired = @"InputsRevisitRequired";

        /// <summary>the value for an instance of the <see cref="OverallValidationStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OverallValidationStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OverallValidationStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OverallValidationStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OverallValidationStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OverallValidationStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OverallValidationStatus && Equals((OverallValidationStatus)obj);
        }

        /// <summary>Returns hashCode for enum OverallValidationStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OverallValidationStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OverallValidationStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OverallValidationStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OverallValidationStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OverallValidationStatus" />.</param>

        public static implicit operator OverallValidationStatus(string value)
        {
            return new OverallValidationStatus(value);
        }

        /// <summary>Implicit operator to convert OverallValidationStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OverallValidationStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OverallValidationStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OverallValidationStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus e1, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.OverallValidationStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}