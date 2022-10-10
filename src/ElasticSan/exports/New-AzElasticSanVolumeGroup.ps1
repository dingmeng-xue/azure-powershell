
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
Create a Volume Group.
.Description
Create a Volume Group.
.Example
$virtualNetworkRule1 =  New-AzElasticSanVirtualNetworkRuleObject -VirtualNetworkResourceId  "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/myresourcegroup/providers/Microsoft.Network/virtualNetworks/myvnet/subnets/subnet1" -Action Allow
$virtualNetworkRule2 =  New-AzElasticSanVirtualNetworkRuleObject -VirtualNetworkResourceId  "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/myresourcegroup/providers/Microsoft.Network/virtualNetworks/myvnet/subnets/subnet2" -Action Allow

New-AzElasticSanVolumeGroup -ResourceGroupName myresourcegroup -ElasticSanName myelasticsan -Name myvolumegroup -ProtocolType 'Iscsi' -Tag @{tag1="value1";tag2="value2"} -NetworkAclsVirtualNetworkRule $virtualNetworkRule1,$virtualNetworkRule2
.Example
New-AzElasticSanVolumeGroup -ResourceGroupName myresourcegroup -ElasticSanName myelasticsan -Name myvolumegroup -ProtocolType 'Iscsi' -Tag @{tag1="value1";tag2="value2"} `
            -NetworkAclsVirtualNetworkRule (
                @{VirtualNetworkResourceId="/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/myresourcegroup/providers/Microsoft.Network/virtualNetworks/myvnet/subnets/subnet1";
                    Action="Allow"},
                @{VirtualNetworkResourceId="/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/myresourcegroup/providers/Microsoft.Network/virtualNetworks/myvnet/subnets/subnet2";
                    Action="Allow"})

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeGroup
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IElasticSanIdentity>: Identity Parameter
  [ElasticSanName <String>]: The name of the ElasticSan.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VolumeGroupName <String>]: The name of the VolumeGroup.
  [VolumeName <String>]: The name of the Volume.

NETWORKACLSVIRTUALNETWORKRULE <IVirtualNetworkRule[]>: The list of virtual network rules.
  VirtualNetworkResourceId <String>: Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
  [Action <Action?>]: The action of virtual network rule.

PARAMETER <IVolumeGroup>: Response for Volume Group request.
  [Tag <IResourceTags>]: Azure resource tags.
    [(Any) <String>]: This indicates any property can be added to this object.
  [Encryption <EncryptionType?>]: Type of encryption
  [NetworkAclsVirtualNetworkRule <IVirtualNetworkRule[]>]: The list of virtual network rules.
    VirtualNetworkResourceId <String>: Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
    [Action <Action?>]: The action of virtual network rule.
  [ProtocolType <StorageTargetType?>]: Type of storage target
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
.Link
https://docs.microsoft.com/powershell/module/az.elasticsan/new-azelasticsanvolumegroup
#>
function New-AzElasticSanVolumeGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeGroup])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
    [System.String]
    # The name of the ElasticSan.
    ${ElasticSanName},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Alias('VolumeGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
    [System.String]
    # The name of the VolumeGroup.
    ${Name},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Create')]
    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVolumeGroup]
    # Response for Volume Group request.
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.EncryptionType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.EncryptionType]
    # Type of encryption
    ${Encryption},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IVirtualNetworkRule[]]
    # The list of virtual network rules.
    # To construct, see NOTES section for NETWORKACLSVIRTUALNETWORKRULE properties and create a hash table.
    ${NetworkAclsVirtualNetworkRule},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.StorageTargetType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.StorageTargetType]
    # Type of storage target
    ${ProtocolType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceTags]))]
    [System.Collections.Hashtable]
    # Azure resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Category('Runtime')]
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

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            Create = 'Az.ElasticSan.private\New-AzElasticSanVolumeGroup_Create';
            CreateExpanded = 'Az.ElasticSan.private\New-AzElasticSanVolumeGroup_CreateExpanded';
            CreateViaIdentity = 'Az.ElasticSan.private\New-AzElasticSanVolumeGroup_CreateViaIdentity';
            CreateViaIdentityExpanded = 'Az.ElasticSan.private\New-AzElasticSanVolumeGroup_CreateViaIdentityExpanded';
        }
        if (('Create', 'CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
