// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Extensions;

    /// <summary>Represents a collection of subscription diagnostic settings resources.</summary>
    public partial class SubscriptionDiagnosticSettingsResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource[] _value;

        /// <summary>The collection of subscription diagnostic settings resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="SubscriptionDiagnosticSettingsResourceCollection" /> instance.
        /// </summary>
        public SubscriptionDiagnosticSettingsResourceCollection()
        {

        }
    }
    /// Represents a collection of subscription diagnostic settings resources.
    public partial interface ISubscriptionDiagnosticSettingsResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.IJsonSerializable
    {
        /// <summary>The collection of subscription diagnostic settings resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of subscription diagnostic settings resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource[] Value { get; set; }

    }
    /// Represents a collection of subscription diagnostic settings resources.
    internal partial interface ISubscriptionDiagnosticSettingsResourceCollectionInternal

    {
        /// <summary>The collection of subscription diagnostic settings resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DiagnosticSetting.Models.Api20210501Preview.ISubscriptionDiagnosticSettingsResource[] Value { get; set; }

    }
}