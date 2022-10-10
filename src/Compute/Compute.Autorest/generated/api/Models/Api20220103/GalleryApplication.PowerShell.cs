// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>
    /// Specifies information about the gallery Application Definition that you want to create or update.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(GalleryApplicationTypeConverter))]
    public partial class GalleryApplication
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryApplication"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplication" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplication DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GalleryApplication(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryApplication"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplication" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplication DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GalleryApplication(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GalleryApplication" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="GalleryApplication" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplication FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryApplication"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GalleryApplication(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryApplicationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Eula"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Eula = (string) content.GetValueForProperty("Eula",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Eula, global::System.Convert.ToString);
            }
            if (content.Contains("PrivacyStatementUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).PrivacyStatementUri = (string) content.GetValueForProperty("PrivacyStatementUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).PrivacyStatementUri, global::System.Convert.ToString);
            }
            if (content.Contains("ReleaseNoteUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).ReleaseNoteUri = (string) content.GetValueForProperty("ReleaseNoteUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).ReleaseNoteUri, global::System.Convert.ToString);
            }
            if (content.Contains("EndOfLifeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).EndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("EndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).EndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SupportedOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).SupportedOSType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) content.GetValueForProperty("SupportedOSType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).SupportedOSType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryApplication"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GalleryApplication(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.GalleryApplicationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Eula"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Eula = (string) content.GetValueForProperty("Eula",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).Eula, global::System.Convert.ToString);
            }
            if (content.Contains("PrivacyStatementUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).PrivacyStatementUri = (string) content.GetValueForProperty("PrivacyStatementUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).PrivacyStatementUri, global::System.Convert.ToString);
            }
            if (content.Contains("ReleaseNoteUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).ReleaseNoteUri = (string) content.GetValueForProperty("ReleaseNoteUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).ReleaseNoteUri, global::System.Convert.ToString);
            }
            if (content.Contains("EndOfLifeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).EndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("EndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).EndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SupportedOSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).SupportedOSType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) content.GetValueForProperty("SupportedOSType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IGalleryApplicationInternal)this).SupportedOSType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specifies information about the gallery Application Definition that you want to create or update.
    [System.ComponentModel.TypeConverter(typeof(GalleryApplicationTypeConverter))]
    public partial interface IGalleryApplication

    {

    }
}