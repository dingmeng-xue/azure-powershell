// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Extensions;

    /// <summary>Properties for EnabledResourceType of a custom location.</summary>
    public partial class EnabledResourceTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClusterExtensionId" /> property.</summary>
        private string _clusterExtensionId;

        /// <summary>Cluster Extension ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string ClusterExtensionId { get => this._clusterExtensionId; set => this._clusterExtensionId = value; }

        /// <summary>Backing field for <see cref="ExtensionType" /> property.</summary>
        private string _extensionType;

        /// <summary>Cluster Extension Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string ExtensionType { get => this._extensionType; set => this._extensionType = value; }

        /// <summary>Backing field for <see cref="TypesMetadata" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypePropertiesTypesMetadataItem> _typesMetadata;

        /// <summary>Metadata of the Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypePropertiesTypesMetadataItem> TypesMetadata { get => this._typesMetadata; set => this._typesMetadata = value; }

        /// <summary>Creates an new <see cref="EnabledResourceTypeProperties" /> instance.</summary>
        public EnabledResourceTypeProperties()
        {

        }
    }
    /// Properties for EnabledResourceType of a custom location.
    public partial interface IEnabledResourceTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IJsonSerializable
    {
        /// <summary>Cluster Extension ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Cluster Extension ID",
        SerializedName = @"clusterExtensionId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterExtensionId { get; set; }
        /// <summary>Cluster Extension Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Cluster Extension Type",
        SerializedName = @"extensionType",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionType { get; set; }
        /// <summary>Metadata of the Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Metadata of the Resource Type",
        SerializedName = @"typesMetadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypePropertiesTypesMetadataItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypePropertiesTypesMetadataItem> TypesMetadata { get; set; }

    }
    /// Properties for EnabledResourceType of a custom location.
    internal partial interface IEnabledResourceTypePropertiesInternal

    {
        /// <summary>Cluster Extension ID</summary>
        string ClusterExtensionId { get; set; }
        /// <summary>Cluster Extension Type</summary>
        string ExtensionType { get; set; }
        /// <summary>Metadata of the Resource Type</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IEnabledResourceTypePropertiesTypesMetadataItem> TypesMetadata { get; set; }

    }
}