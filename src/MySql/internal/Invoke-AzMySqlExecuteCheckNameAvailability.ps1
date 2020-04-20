
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Check the availability of name for resource
.Description
Check the availability of name for resource
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Link
https://docs.microsoft.com/en-us/powershell/module/az.mysql/invoke-azmysqlexecutechecknameavailability
#>
function Invoke-AzMySqlExecuteCheckNameAvailability {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.INameAvailability])]
[CmdletBinding(DefaultParameterSetName='ExecuteExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Execute')]
    [Parameter(ParameterSetName='ExecuteExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='ExecuteViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ExecuteViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Execute', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ExecuteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.INameAvailabilityRequest]
    # Request from client to check resource name availability.
    # To construct, see NOTES section for NAMEAVAILABILITYREQUEST properties and create a hash table.
    ${NameAvailabilityRequest},

    [Parameter(ParameterSetName='ExecuteExpanded', Mandatory)]
    [Parameter(ParameterSetName='ExecuteViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
    [System.String]
    # Resource name to verify.
    ${Name},

    [Parameter(ParameterSetName='ExecuteExpanded')]
    [Parameter(ParameterSetName='ExecuteViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Body')]
    [System.String]
    # Resource type used for verification.
    ${Type},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MySql.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Execute = 'Az.MySql.private\Invoke-AzMySqlExecuteCheckNameAvailability_Execute';
            ExecuteExpanded = 'Az.MySql.private\Invoke-AzMySqlExecuteCheckNameAvailability_ExecuteExpanded';
            ExecuteViaIdentity = 'Az.MySql.private\Invoke-AzMySqlExecuteCheckNameAvailability_ExecuteViaIdentity';
            ExecuteViaIdentityExpanded = 'Az.MySql.private\Invoke-AzMySqlExecuteCheckNameAvailability_ExecuteViaIdentityExpanded';
        }
        if (('Execute', 'ExecuteExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
