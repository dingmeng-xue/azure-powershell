// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(AppIdentityTypeConverter))]
    public partial class AppIdentity
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.AppIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AppIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerAppName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ContainerAppName = (string) content.GetValueForProperty("ContainerAppName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ContainerAppName, global::System.Convert.ToString);
            }
            if (content.Contains("AuthConfigName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).AuthConfigName = (string) content.GetValueForProperty("AuthConfigName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).AuthConfigName, global::System.Convert.ToString);
            }
            if (content.Contains("RevisionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).RevisionName = (string) content.GetValueForProperty("RevisionName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).RevisionName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ReplicaName = (string) content.GetValueForProperty("ReplicaName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ReplicaName, global::System.Convert.ToString);
            }
            if (content.Contains("EnvironmentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).EnvironmentName = (string) content.GetValueForProperty("EnvironmentName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).EnvironmentName, global::System.Convert.ToString);
            }
            if (content.Contains("ComponentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ComponentName = (string) content.GetValueForProperty("ComponentName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ComponentName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).CertificateName = (string) content.GetValueForProperty("CertificateName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).CertificateName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).StorageName = (string) content.GetValueForProperty("StorageName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).StorageName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SourceControlName = (string) content.GetValueForProperty("SourceControlName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SourceControlName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.AppIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AppIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerAppName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ContainerAppName = (string) content.GetValueForProperty("ContainerAppName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ContainerAppName, global::System.Convert.ToString);
            }
            if (content.Contains("AuthConfigName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).AuthConfigName = (string) content.GetValueForProperty("AuthConfigName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).AuthConfigName, global::System.Convert.ToString);
            }
            if (content.Contains("RevisionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).RevisionName = (string) content.GetValueForProperty("RevisionName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).RevisionName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicaName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ReplicaName = (string) content.GetValueForProperty("ReplicaName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ReplicaName, global::System.Convert.ToString);
            }
            if (content.Contains("EnvironmentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).EnvironmentName = (string) content.GetValueForProperty("EnvironmentName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).EnvironmentName, global::System.Convert.ToString);
            }
            if (content.Contains("ComponentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ComponentName = (string) content.GetValueForProperty("ComponentName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).ComponentName, global::System.Convert.ToString);
            }
            if (content.Contains("CertificateName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).CertificateName = (string) content.GetValueForProperty("CertificateName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).CertificateName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).StorageName = (string) content.GetValueForProperty("StorageName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).StorageName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SourceControlName = (string) content.GetValueForProperty("SourceControlName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).SourceControlName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.AppIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AppIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.AppIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AppIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AppIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AppIdentity" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(AppIdentityTypeConverter))]
    public partial interface IAppIdentity

    {

    }
}