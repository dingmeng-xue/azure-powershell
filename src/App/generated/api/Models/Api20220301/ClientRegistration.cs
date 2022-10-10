// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    /// </summary>
    public partial class ClientRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IClientRegistration,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IClientRegistrationInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The Client ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; set => this._clientId = value; }

        /// <summary>Backing field for <see cref="ClientSecretSettingName" /> property.</summary>
        private string _clientSecretSettingName;

        /// <summary>The app setting name that contains the client secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string ClientSecretSettingName { get => this._clientSecretSettingName; set => this._clientSecretSettingName = value; }

        /// <summary>Creates an new <see cref="ClientRegistration" /> instance.</summary>
        public ClientRegistration()
        {

        }
    }
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    public partial interface IClientRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>The Client ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Client ID of the app used for login.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get; set; }
        /// <summary>The app setting name that contains the client secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app setting name that contains the client secret.",
        SerializedName = @"clientSecretSettingName",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecretSettingName { get; set; }

    }
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    internal partial interface IClientRegistrationInternal

    {
        /// <summary>The Client ID of the app used for login.</summary>
        string ClientId { get; set; }
        /// <summary>The app setting name that contains the client secret.</summary>
        string ClientSecretSettingName { get; set; }

    }
}