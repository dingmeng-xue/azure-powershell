// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support
{

    /// <summary>Enum indicating a type of graph query.</summary>
    public partial struct ResultKind :
        System.IEquatable<ResultKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind Basic = @"basic";

        /// <summary>the value for an instance of the <see cref="ResultKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResultKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResultKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResultKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResultKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ResultKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResultKind && Equals((ResultKind)obj);
        }

        /// <summary>Returns hashCode for enum ResultKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ResultKind"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResultKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResultKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResultKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResultKind" />.</param>

        public static implicit operator ResultKind(string value)
        {
            return new ResultKind(value);
        }

        /// <summary>Implicit operator to convert ResultKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResultKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResultKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind e1, Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResultKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind e1, Microsoft.Azure.PowerShell.Cmdlets.ResourceGraph.Support.ResultKind e2)
        {
            return e2.Equals(e1);
        }
    }
}