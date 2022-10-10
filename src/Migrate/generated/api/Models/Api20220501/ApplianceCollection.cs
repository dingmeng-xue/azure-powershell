// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Collection of appliance details.</summary>
    public partial class ApplianceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IApplianceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IApplianceCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationAppliance[] _value;

        /// <summary>The appliance details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationAppliance[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ApplianceCollection" /> instance.</summary>
        public ApplianceCollection()
        {

        }
    }
    /// Collection of appliance details.
    public partial interface IApplianceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of next link.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The appliance details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The appliance details.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationAppliance) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationAppliance[] Value { get; set; }

    }
    /// Collection of appliance details.
    internal partial interface IApplianceCollectionInternal

    {
        /// <summary>The value of next link.</summary>
        string NextLink { get; set; }
        /// <summary>The appliance details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationAppliance[] Value { get; set; }

    }
}