// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Item Level kubernetes persistent volume target info for restore operation</summary>
    public partial class KubernetesPvRestoreCriteria :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IKubernetesPvRestoreCriteria,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IKubernetesPvRestoreCriteriaInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IItemLevelRestoreCriteria"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IItemLevelRestoreCriteria __itemLevelRestoreCriteria = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.ItemLevelRestoreCriteria();

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Selected persistent volume claim name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IItemLevelRestoreCriteriaInternal)__itemLevelRestoreCriteria).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IItemLevelRestoreCriteriaInternal)__itemLevelRestoreCriteria).ObjectType = value ; }

        /// <summary>Backing field for <see cref="StorageClassName" /> property.</summary>
        private string _storageClassName;

        /// <summary>Selected storage class name for restore operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string StorageClassName { get => this._storageClassName; set => this._storageClassName = value; }

        /// <summary>Creates an new <see cref="KubernetesPvRestoreCriteria" /> instance.</summary>
        public KubernetesPvRestoreCriteria()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__itemLevelRestoreCriteria), __itemLevelRestoreCriteria);
            await eventListener.AssertObjectIsValid(nameof(__itemLevelRestoreCriteria), __itemLevelRestoreCriteria);
        }
    }
    /// Item Level kubernetes persistent volume target info for restore operation
    public partial interface IKubernetesPvRestoreCriteria :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IItemLevelRestoreCriteria
    {
        /// <summary>Selected persistent volume claim name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selected persistent volume claim name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Selected storage class name for restore operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selected storage class name for restore operation",
        SerializedName = @"storageClassName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageClassName { get; set; }

    }
    /// Item Level kubernetes persistent volume target info for restore operation
    internal partial interface IKubernetesPvRestoreCriteriaInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220501.IItemLevelRestoreCriteriaInternal
    {
        /// <summary>Selected persistent volume claim name</summary>
        string Name { get; set; }
        /// <summary>Selected storage class name for restore operation</summary>
        string StorageClassName { get; set; }

    }
}