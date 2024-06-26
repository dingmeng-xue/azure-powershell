// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.PowerShell;

    /// <summary>Filter for the Event Subscription.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventSubscriptionFilterTypeConverter))]
    public partial class EventSubscriptionFilter
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventSubscriptionFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilter" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilter DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventSubscriptionFilter(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventSubscriptionFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilter" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilter DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventSubscriptionFilter(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventSubscriptionFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventSubscriptionFilter(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubjectBeginsWith"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectBeginsWith = (string) content.GetValueForProperty("SubjectBeginsWith",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectBeginsWith, global::System.Convert.ToString);
            }
            if (content.Contains("SubjectEndsWith"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectEndsWith = (string) content.GetValueForProperty("SubjectEndsWith",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectEndsWith, global::System.Convert.ToString);
            }
            if (content.Contains("IncludedEventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IncludedEventType = (System.Collections.Generic.List<string>) content.GetValueForProperty("IncludedEventType",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IncludedEventType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsSubjectCaseSensitive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IsSubjectCaseSensitive = (bool?) content.GetValueForProperty("IsSubjectCaseSensitive",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IsSubjectCaseSensitive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableAdvancedFilteringOnArray"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).EnableAdvancedFilteringOnArray = (bool?) content.GetValueForProperty("EnableAdvancedFilteringOnArray",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).EnableAdvancedFilteringOnArray, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdvancedFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).AdvancedFilter = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAdvancedFilter>) content.GetValueForProperty("AdvancedFilter",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).AdvancedFilter, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAdvancedFilter>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.AdvancedFilterTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventSubscriptionFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventSubscriptionFilter(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubjectBeginsWith"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectBeginsWith = (string) content.GetValueForProperty("SubjectBeginsWith",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectBeginsWith, global::System.Convert.ToString);
            }
            if (content.Contains("SubjectEndsWith"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectEndsWith = (string) content.GetValueForProperty("SubjectEndsWith",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).SubjectEndsWith, global::System.Convert.ToString);
            }
            if (content.Contains("IncludedEventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IncludedEventType = (System.Collections.Generic.List<string>) content.GetValueForProperty("IncludedEventType",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IncludedEventType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsSubjectCaseSensitive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IsSubjectCaseSensitive = (bool?) content.GetValueForProperty("IsSubjectCaseSensitive",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).IsSubjectCaseSensitive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableAdvancedFilteringOnArray"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).EnableAdvancedFilteringOnArray = (bool?) content.GetValueForProperty("EnableAdvancedFilteringOnArray",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).EnableAdvancedFilteringOnArray, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AdvancedFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).AdvancedFilter = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAdvancedFilter>) content.GetValueForProperty("AdvancedFilter",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilterInternal)this).AdvancedFilter, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAdvancedFilter>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.AdvancedFilterTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventSubscriptionFilter" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventSubscriptionFilter" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventSubscriptionFilter FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Filter for the Event Subscription.
    [System.ComponentModel.TypeConverter(typeof(EventSubscriptionFilterTypeConverter))]
    public partial interface IEventSubscriptionFilter

    {

    }
}