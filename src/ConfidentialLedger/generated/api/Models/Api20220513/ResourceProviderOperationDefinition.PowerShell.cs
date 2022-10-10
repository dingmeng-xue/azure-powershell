// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513
{
    using Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.PowerShell;

    /// <summary>Describes the Resource Provider Operation.</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceProviderOperationDefinitionTypeConverter))]
    public partial class ResourceProviderOperationDefinition
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ResourceProviderOperationDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinition DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ResourceProviderOperationDefinition(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ResourceProviderOperationDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinition"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinition DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ResourceProviderOperationDefinition(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ResourceProviderOperationDefinition" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ResourceProviderOperationDefinition" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinition FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ResourceProviderOperationDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ResourceProviderOperationDefinition(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Display"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ResourceProviderOperationDisplayTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("IsDataAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).IsDataAction = (bool?) content.GetValueForProperty("IsDataAction",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).IsDataAction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisplayProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayProvider, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayResource, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ResourceProviderOperationDefinition"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ResourceProviderOperationDefinition(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Display"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Display = (Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDisplay) content.GetValueForProperty("Display",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Display, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.ResourceProviderOperationDisplayTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("IsDataAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).IsDataAction = (bool?) content.GetValueForProperty("IsDataAction",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).IsDataAction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisplayProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayProvider = (string) content.GetValueForProperty("DisplayProvider",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayProvider, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayResource = (string) content.GetValueForProperty("DisplayResource",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayResource, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayOperation = (string) content.GetValueForProperty("DisplayOperation",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayOperation, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayDescription = (string) content.GetValueForProperty("DisplayDescription",((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20220513.IResourceProviderOperationDefinitionInternal)this).DisplayDescription, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the Resource Provider Operation.
    [System.ComponentModel.TypeConverter(typeof(ResourceProviderOperationDefinitionTypeConverter))]
    public partial interface IResourceProviderOperationDefinition

    {

    }
}