// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.Extensions;

    /// <summary>
    /// the dictionary of custom properties to include with the post operation. These data are appended to the webhook payload.
    /// </summary>
    public partial class ActionGroupWebhookProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroupWebhookProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroupWebhookPropertiesInternal
    {

        /// <summary>Creates an new <see cref="ActionGroupWebhookProperties" /> instance.</summary>
        public ActionGroupWebhookProperties()
        {

        }
    }
    /// the dictionary of custom properties to include with the post operation. These data are appended to the webhook payload.
    public partial interface IActionGroupWebhookProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Runtime.IAssociativeArray<string>
    {

    }
    /// the dictionary of custom properties to include with the post operation. These data are appended to the webhook payload.
    internal partial interface IActionGroupWebhookPropertiesInternal

    {

    }
}