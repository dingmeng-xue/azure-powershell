// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>The properties of a private endpoint connection</summary>
    public partial class PrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointConnectionPropertiesInternal
    {

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.PrivateEndpoint()); set { {_privateEndpoint = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointInternal)PrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointInternal)PrivateEndpoint).Id = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.PrivateLinkServiceConnectionState()); set { {_privateLinkServiceConnectionState = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpoint _privateEndpoint;

        /// <summary>Private endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpoint PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.PrivateEndpoint()); set => this._privateEndpoint = value; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpointInternal)PrivateEndpoint).Id; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionState _privateLinkServiceConnectionState;

        /// <summary>Private endpoint connection state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.PrivateLinkServiceConnectionState()); set => this._privateLinkServiceConnectionState = value; }

        /// <summary>Actions required for a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionRequired = value ?? null; }

        /// <summary>The description for the current state of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>The status of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status = value ; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProperties" /> instance.</summary>
        public PrivateEndpointConnectionProperties()
        {

        }
    }
    /// The properties of a private endpoint connection
    public partial interface IPrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get;  }
        /// <summary>Actions required for a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Actions required for a private endpoint connection",
        SerializedName = @"actionRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description for the current state of a private endpoint connection",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The status of a private endpoint connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The status of a private endpoint connection",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>Provisioning state of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the private endpoint connection.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? ProvisioningState { get;  }

    }
    /// The properties of a private endpoint connection
    internal partial interface IPrivateEndpointConnectionPropertiesInternal

    {
        /// <summary>Private endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>The resource identifier.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Private endpoint connection state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20220401Preview.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>Actions required for a private endpoint connection</summary>
        string PrivateLinkServiceConnectionStateActionRequired { get; set; }
        /// <summary>The description for the current state of a private endpoint connection</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>The status of a private endpoint connection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateLinkServiceConnectionStatus PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>Provisioning state of the private endpoint connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PrivateEndpointConnectionProvisioningState? ProvisioningState { get; set; }

    }
}