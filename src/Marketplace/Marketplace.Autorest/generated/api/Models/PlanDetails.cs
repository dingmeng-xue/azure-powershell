// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Return plan with request details</summary>
    public partial class PlanDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetailsInternal
    {

        /// <summary>Backing field for <see cref="Justification" /> property.</summary>
        private string _justification;

        /// <summary>Gets or sets user's justification for the plan's request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Justification { get => this._justification; set => this._justification = value; }

        /// <summary>Internal Acessors for RequestDate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetailsInternal.RequestDate { get => (this._requestDate = this._requestDate ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Any()); set { {_requestDate = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPlanDetailsInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        /// <summary>Gets or sets Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Backing field for <see cref="RequestDate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAny _requestDate;

        /// <summary>Gets request date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAny RequestDate { get => (this._requestDate = this._requestDate ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Any()); }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Gets the plan status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Gets or sets the subscription id that the user is requesting to add the plan to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="SubscriptionName" /> property.</summary>
        private string _subscriptionName;

        /// <summary>
        /// Gets or sets the subscription name that the user is requesting to add the plan to
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string SubscriptionName { get => this._subscriptionName; set => this._subscriptionName = value; }

        /// <summary>Creates an new <see cref="PlanDetails" /> instance.</summary>
        public PlanDetails()
        {

        }
    }
    /// Return plan with request details
    public partial interface IPlanDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets user's justification for the plan's request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets user's justification for the plan's request",
        SerializedName = @"justification",
        PossibleTypes = new [] { typeof(string) })]
        string Justification { get; set; }
        /// <summary>Gets or sets Plan Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets Plan Id ",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanId { get; set; }
        /// <summary>Gets request date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets request date",
        SerializedName = @"requestDate",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAny RequestDate { get;  }
        /// <summary>Gets the plan status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the plan status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PSArgumentCompleterAttribute("Pending", "Rejected", "Approved", "None")]
        string Status { get;  }
        /// <summary>Gets or sets the subscription id that the user is requesting to add the plan to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the subscription id that the user is requesting to add the plan to",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>
        /// Gets or sets the subscription name that the user is requesting to add the plan to
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the subscription name that the user is requesting to add the plan to",
        SerializedName = @"subscriptionName",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionName { get; set; }

    }
    /// Return plan with request details
    internal partial interface IPlanDetailsInternal

    {
        /// <summary>Gets or sets user's justification for the plan's request</summary>
        string Justification { get; set; }
        /// <summary>Gets or sets Plan Id</summary>
        string PlanId { get; set; }
        /// <summary>Gets request date</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IAny RequestDate { get; set; }
        /// <summary>Gets the plan status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PSArgumentCompleterAttribute("Pending", "Rejected", "Approved", "None")]
        string Status { get; set; }
        /// <summary>Gets or sets the subscription id that the user is requesting to add the plan to</summary>
        string SubscriptionId { get; set; }
        /// <summary>
        /// Gets or sets the subscription name that the user is requesting to add the plan to
        /// </summary>
        string SubscriptionName { get; set; }

    }
}