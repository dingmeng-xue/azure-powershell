// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>The parameters required to execute insights operation on the given entity.</summary>
    public partial class EntityGetInsightsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityGetInsightsParameters,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityGetInsightsParametersInternal
    {

        /// <summary>Backing field for <see cref="AddDefaultExtendedTimeRange" /> property.</summary>
        private bool? _addDefaultExtendedTimeRange;

        /// <summary>
        /// Indicates if query time range should be extended with default time range of the query. Default value is false
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? AddDefaultExtendedTimeRange { get => this._addDefaultExtendedTimeRange; set => this._addDefaultExtendedTimeRange = value; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime _endTime;

        /// <summary>The end timeline date, so the results returned are before this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="InsightQueryId" /> property.</summary>
        private string[] _insightQueryId;

        /// <summary>
        /// List of Insights Query Id. If empty, default value is all insights of this entity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] InsightQueryId { get => this._insightQueryId; set => this._insightQueryId = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime _startTime;

        /// <summary>The start timeline date, so the results returned are after this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Creates an new <see cref="EntityGetInsightsParameters" /> instance.</summary>
        public EntityGetInsightsParameters()
        {

        }
    }
    /// The parameters required to execute insights operation on the given entity.
    public partial interface IEntityGetInsightsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates if query time range should be extended with default time range of the query. Default value is false
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if query time range should be extended with default time range of the query. Default value is false",
        SerializedName = @"addDefaultExtendedTimeRange",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AddDefaultExtendedTimeRange { get; set; }
        /// <summary>The end timeline date, so the results returned are before this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The end timeline date, so the results returned are before this date.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime EndTime { get; set; }
        /// <summary>
        /// List of Insights Query Id. If empty, default value is all insights of this entity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Insights Query Id. If empty, default value is all insights of this entity",
        SerializedName = @"insightQueryIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] InsightQueryId { get; set; }
        /// <summary>The start timeline date, so the results returned are after this date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The start timeline date, so the results returned are after this date.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTime { get; set; }

    }
    /// The parameters required to execute insights operation on the given entity.
    internal partial interface IEntityGetInsightsParametersInternal

    {
        /// <summary>
        /// Indicates if query time range should be extended with default time range of the query. Default value is false
        /// </summary>
        bool? AddDefaultExtendedTimeRange { get; set; }
        /// <summary>The end timeline date, so the results returned are before this date.</summary>
        global::System.DateTime EndTime { get; set; }
        /// <summary>
        /// List of Insights Query Id. If empty, default value is all insights of this entity
        /// </summary>
        string[] InsightQueryId { get; set; }
        /// <summary>The start timeline date, so the results returned are after this date.</summary>
        global::System.DateTime StartTime { get; set; }

    }
}