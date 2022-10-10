// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Pause replication input.</summary>
    public partial class PauseReplicationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputInternal
    {

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputPropertiesInternal)Property).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputPropertiesInternal)Property).InstanceType = value ; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.PauseReplicationInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputProperties _property;

        /// <summary>Pause replication input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.PauseReplicationInputProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="PauseReplicationInput" /> instance.</summary>
        public PauseReplicationInput()
        {

        }
    }
    /// Pause replication input.
    public partial interface IPauseReplicationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Pause replication input.
    internal partial interface IPauseReplicationInputInternal

    {
        /// <summary>The class type.</summary>
        string InstanceType { get; set; }
        /// <summary>Pause replication input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IPauseReplicationInputProperties Property { get; set; }

    }
}