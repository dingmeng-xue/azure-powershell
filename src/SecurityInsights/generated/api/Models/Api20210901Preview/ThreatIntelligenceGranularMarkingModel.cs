// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Describes threat granular marking model entity</summary>
    public partial class ThreatIntelligenceGranularMarkingModel :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModelInternal
    {

        /// <summary>Backing field for <see cref="Language" /> property.</summary>
        private string _language;

        /// <summary>Language granular marking model</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Language { get => this._language; set => this._language = value; }

        /// <summary>Backing field for <see cref="MarkingRef" /> property.</summary>
        private int? _markingRef;

        /// <summary>marking reference granular marking model</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public int? MarkingRef { get => this._markingRef; set => this._markingRef = value; }

        /// <summary>Backing field for <see cref="Selector" /> property.</summary>
        private string[] _selector;

        /// <summary>granular marking model selectors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] Selector { get => this._selector; set => this._selector = value; }

        /// <summary>Creates an new <see cref="ThreatIntelligenceGranularMarkingModel" /> instance.</summary>
        public ThreatIntelligenceGranularMarkingModel()
        {

        }
    }
    /// Describes threat granular marking model entity
    public partial interface IThreatIntelligenceGranularMarkingModel :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Language granular marking model</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Language granular marking model",
        SerializedName = @"language",
        PossibleTypes = new [] { typeof(string) })]
        string Language { get; set; }
        /// <summary>marking reference granular marking model</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"marking reference granular marking model",
        SerializedName = @"markingRef",
        PossibleTypes = new [] { typeof(int) })]
        int? MarkingRef { get; set; }
        /// <summary>granular marking model selectors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"granular marking model selectors",
        SerializedName = @"selectors",
        PossibleTypes = new [] { typeof(string) })]
        string[] Selector { get; set; }

    }
    /// Describes threat granular marking model entity
    internal partial interface IThreatIntelligenceGranularMarkingModelInternal

    {
        /// <summary>Language granular marking model</summary>
        string Language { get; set; }
        /// <summary>marking reference granular marking model</summary>
        int? MarkingRef { get; set; }
        /// <summary>granular marking model selectors</summary>
        string[] Selector { get; set; }

    }
}