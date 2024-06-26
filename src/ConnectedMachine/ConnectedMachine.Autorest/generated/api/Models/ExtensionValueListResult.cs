// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>The List Extension Metadata response.</summary>
    public partial class ExtensionValueListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValueListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValueListResultInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValue> Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValueListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValue> _value;

        /// <summary>The list of extension metadata</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValue> Value { get => this._value; }

        /// <summary>Creates an new <see cref="ExtensionValueListResult" /> instance.</summary>
        public ExtensionValueListResult()
        {

        }
    }
    /// The List Extension Metadata response.
    public partial interface IExtensionValueListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>The list of extension metadata</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of extension metadata",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValue) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValue> Value { get;  }

    }
    /// The List Extension Metadata response.
    internal partial interface IExtensionValueListResultInternal

    {
        /// <summary>The list of extension metadata</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValue> Value { get; set; }

    }
}