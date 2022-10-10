// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>
    /// Recovery virtual network input to create new virtual network from given source network.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(NewRecoveryVirtualNetworkTypeConverter))]
    public partial class NewRecoveryVirtualNetwork
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.NewRecoveryVirtualNetwork"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetwork" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetwork DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NewRecoveryVirtualNetwork(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.NewRecoveryVirtualNetwork"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetwork" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetwork DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NewRecoveryVirtualNetwork(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NewRecoveryVirtualNetwork" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NewRecoveryVirtualNetwork" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetwork FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.NewRecoveryVirtualNetwork"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NewRecoveryVirtualNetwork(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryVirtualNetworkResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkResourceGroupName = (string) content.GetValueForProperty("RecoveryVirtualNetworkResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryVirtualNetworkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkName = (string) content.GetValueForProperty("RecoveryVirtualNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryVirtualNetworkCustomDetailsInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryVirtualNetworkCustomDetailsInternal)this).ResourceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.NewRecoveryVirtualNetwork"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NewRecoveryVirtualNetwork(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryVirtualNetworkResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkResourceGroupName = (string) content.GetValueForProperty("RecoveryVirtualNetworkResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryVirtualNetworkName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkName = (string) content.GetValueForProperty("RecoveryVirtualNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.INewRecoveryVirtualNetworkInternal)this).RecoveryVirtualNetworkName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryVirtualNetworkCustomDetailsInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryVirtualNetworkCustomDetailsInternal)this).ResourceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery virtual network input to create new virtual network from given source network.
    [System.ComponentModel.TypeConverter(typeof(NewRecoveryVirtualNetworkTypeConverter))]
    public partial interface INewRecoveryVirtualNetwork

    {

    }
}