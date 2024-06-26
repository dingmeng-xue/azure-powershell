// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>Username / Password Credentials to connect to guest.</summary>
    public partial class GuestCredential :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGuestCredential,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGuestCredentialInternal
    {

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>The password to connect with the guest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>The username to connect with the guest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="GuestCredential" /> instance.</summary>
        public GuestCredential()
        {

        }
    }
    /// Username / Password Credentials to connect to guest.
    public partial interface IGuestCredential :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        /// <summary>The password to connect with the guest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = true,
        Description = @"The password to connect with the guest.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>The username to connect with the guest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The username to connect with the guest.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// Username / Password Credentials to connect to guest.
    internal partial interface IGuestCredentialInternal

    {
        /// <summary>The password to connect with the guest.</summary>
        string Password { get; set; }
        /// <summary>The username to connect with the guest.</summary>
        string Username { get; set; }

    }
}