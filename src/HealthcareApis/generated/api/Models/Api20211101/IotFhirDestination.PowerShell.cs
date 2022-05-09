// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.PowerShell;

    /// <summary>IoT Connector FHIR destination definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(IotFhirDestinationTypeConverter))]
    public partial class IotFhirDestination
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotFhirDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestination" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestination DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IotFhirDestination(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotFhirDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestination" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestination DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IotFhirDestination(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IotFhirDestination" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestination FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotFhirDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IotFhirDestination(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotFhirDestinationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FhirMapping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMapping = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingProperties) content.GetValueForProperty("FhirMapping",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMapping, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceIdentityResolutionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ResourceIdentityResolutionType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.IotIdentityResolutionType) content.GetValueForProperty("ResourceIdentityResolutionType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ResourceIdentityResolutionType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.IotIdentityResolutionType.CreateFrom);
            }
            if (content.Contains("FhirServiceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirServiceResourceId = (string) content.GetValueForProperty("FhirServiceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirServiceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FhirMappingContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMappingContent = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingPropertiesContent) content.GetValueForProperty("FhirMappingContent",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMappingContent, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesContentTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotFhirDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IotFhirDestination(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotFhirDestinationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceCoreInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ILocationBasedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FhirMapping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMapping = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingProperties) content.GetValueForProperty("FhirMapping",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMapping, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceIdentityResolutionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ResourceIdentityResolutionType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.IotIdentityResolutionType) content.GetValueForProperty("ResourceIdentityResolutionType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).ResourceIdentityResolutionType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.IotIdentityResolutionType.CreateFrom);
            }
            if (content.Contains("FhirServiceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirServiceResourceId = (string) content.GetValueForProperty("FhirServiceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirServiceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("FhirMappingContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMappingContent = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingPropertiesContent) content.GetValueForProperty("FhirMappingContent",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotFhirDestinationInternal)this).FhirMappingContent, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesContentTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// IoT Connector FHIR destination definition.
    [System.ComponentModel.TypeConverter(typeof(IotFhirDestinationTypeConverter))]
    public partial interface IIotFhirDestination

    {

    }
}