
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ActionGroup.
.Description
Create an in-memory object for ActionGroup.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.ActionGroup
.Link
https://docs.microsoft.com/powershell/module/az.ActivityLogAlert/new-AzActivityLogAlertActionGroupObject
#>
function New-AzActivityLogAlertActionGroupObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.ActionGroup')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="The resource ID of the Action Group. This cannot be null or empty.")]
        [string]
        $Id,
        [Parameter(HelpMessage="the dictionary of custom properties to include with the post operation. These data are appended to the webhook payload.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.IActionGroupWebhookProperties]
        $WebhookProperty
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Monitor.ActivityLogAlert.Models.Api20201001.ActionGroup]::New()

        if ($PSBoundParameters.ContainsKey('Id')) {
            $Object.Id = $Id
        }
        if ($PSBoundParameters.ContainsKey('WebhookProperty')) {
            $Object.WebhookProperty = $WebhookProperty
        }
        return $Object
    }
}

