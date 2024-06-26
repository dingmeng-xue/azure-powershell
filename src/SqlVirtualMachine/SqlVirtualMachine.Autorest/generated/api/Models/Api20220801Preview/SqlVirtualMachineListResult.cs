// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>A list of SQL virtual machines.</summary>
    public partial class SqlVirtualMachineListResult :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineListResult,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine[] Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to retrieve next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine[] _value;

        /// <summary>Array of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="SqlVirtualMachineListResult" /> instance.</summary>
        public SqlVirtualMachineListResult()
        {

        }
    }
    /// A list of SQL virtual machines.
    public partial interface ISqlVirtualMachineListResult :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>Link to retrieve next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to retrieve next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of results.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine) })]
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine[] Value { get;  }

    }
    /// A list of SQL virtual machines.
    internal partial interface ISqlVirtualMachineListResultInternal

    {
        /// <summary>Link to retrieve next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Array of results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachine[] Value { get; set; }

    }
}