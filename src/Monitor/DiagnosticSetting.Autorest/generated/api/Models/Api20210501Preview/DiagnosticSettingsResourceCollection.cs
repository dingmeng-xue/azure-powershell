// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Extensions;

    /// <summary>Represents a collection of alert rule resources.</summary>
    public partial class DiagnosticSettingsResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResource[] _value;

        /// <summary>The collection of diagnostic settings resources;.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DiagnosticSettingsResourceCollection" /> instance.</summary>
        public DiagnosticSettingsResourceCollection()
        {

        }
    }
    /// Represents a collection of alert rule resources.
    public partial interface IDiagnosticSettingsResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IJsonSerializable
    {
        /// <summary>The collection of diagnostic settings resources;.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of diagnostic settings resources;.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResource[] Value { get; set; }

    }
    /// Represents a collection of alert rule resources.
    internal partial interface IDiagnosticSettingsResourceCollectionInternal

    {
        /// <summary>The collection of diagnostic settings resources;.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.IDiagnosticSettingsResource[] Value { get; set; }

    }
}