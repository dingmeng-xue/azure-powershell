
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
The operation to Create a virtual machine instance.
Please note some properties can be set only during virtual machine instance creation.
.Description
The operation to Create a virtual machine instance.
Please note some properties can be set only during virtual machine instance creation.
.Example
New-AzConnectedVMwareVM -ExtendedLocationName "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/test-cl" -ExtendedLocationType "CustomLocation" -InfrastructureProfileTemplateId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/test-vmtmpl" -InfrastructureProfileVCenterId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/vcenters/test-vc" -PlacementProfileResourcePoolId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/resourcepools/test-rp" -MachineId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.HybridCompute/machines/test-machine"
.Example
New-AzConnectedVMwareVM -ExtendedLocationName "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/test-cl" -ExtendedLocationType "CustomLocation" -InfrastructureProfileTemplateId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/test-vmtmpl" -InfrastructureProfileVCenterId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/vcenters/test-vc" -PlacementProfileClusterId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/clusters/test-cluster" -MachineId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.HybridCompute/machines/test-machine"
.Example
New-AzConnectedVMwareVM -ExtendedLocationName "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/test-cl" -ExtendedLocationType "CustomLocation" -InfrastructureProfileTemplateId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/test-vmtmpl" -InfrastructureProfileVCenterId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/vcenters/test-vc" -PlacementProfileHostId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/hosts/test-host" -MachineId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.HybridCompute/machines/test-machine"
.Example
New-AzConnectedVMwareVM -ExtendedLocationName "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourcegroups/test-rg/providers/microsoft.extendedlocation/customlocations/test-cl" -ExtendedLocationType "CustomLocation" -InfrastructureProfileInventoryItemId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.ConnectedVMwarevSphere/VCenters/test-vc/InventoryItems/vm-1528583" -MachineId "/subscriptions/204898ee-cd13-4332-b9d4-55ca5c25496d/resourceGroups/test-rg/providers/Microsoft.HybridCompute/machines/test-machine-ps"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualMachineInstance
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

NETWORKPROFILENETWORKINTERFACE <INetworkInterface[]>: Gets or sets the list of network interfaces associated with the virtual machine.
  [DeviceKey <Int32?>]: Gets or sets the device key value.
  [IPSettingAllocationMethod <String>]: Gets or sets the nic allocation method.
  [IPSettingDnsServer <List<String>>]: Gets or sets the dns servers.
  [IPSettingGateway <List<String>>]: Gets or sets the gateway.
  [IPSettingIpaddress <String>]: Gets or sets the ip address for the nic.
  [IPSettingSubnetMask <String>]: Gets or sets the mask.
  [Name <String>]: Gets or sets the name of the network interface.
  [NetworkId <String>]: Gets or sets the ARM Id of the network resource to connect the virtual machine.
  [NicType <String>]: NIC type
  [PowerOnBoot <String>]: Gets or sets the power on boot.

STORAGEPROFILEDISK <IVirtualDisk[]>: Gets or sets the list of virtual disks associated with the virtual machine.
  [ControllerKey <Int32?>]: Gets or sets the controller id.
  [DeviceKey <Int32?>]: Gets or sets the device key value.
  [DeviceName <String>]: Gets or sets the device name.
  [DiskMode <String>]: Gets or sets the disk mode.
  [DiskSizeGb <Int32?>]: Gets or sets the disk total size.
  [DiskType <String>]: Gets or sets the disk backing type.
  [Name <String>]: Gets or sets the name of the virtual disk.
  [UnitNumber <Int32?>]: Gets or sets the unit number of the disk on the controller.
.Link
https://learn.microsoft.com/powershell/module/az.connectedvmware/new-azconnectedvmwarevm
#>
function New-AzConnectedVMwareVM {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualMachineInstance])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Path')]
    [System.String]
    # The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended.
    ${MachineId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # The extended location name.
    ${ExtendedLocationName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # The extended location type.
    ${ExtendedLocationType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.Int32]
    # Gets or sets memory size in MBs for the vm.
    ${HardwareProfileMemorySizeMb},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.Int32]
    # Gets or sets the number of cores per socket for the vm.
    # Defaults to 1 if unspecified.
    ${HardwareProfileNumCoresPerSocket},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.Int32]
    # Gets or sets the number of vCPUs for the vm.
    ${HardwareProfileNumCpus},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PSArgumentCompleterAttribute("bios", "efi")]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Firmware type
    ${InfrastructureProfileFirmwareType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the inventory Item ID for the virtual machine.
    ${InfrastructureProfileInventoryItemId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the SMBIOS UUID of the vm.
    ${InfrastructureProfileSmbiosUuid},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the ARM Id of the template resource to deploy the virtual machine.
    ${InfrastructureProfileTemplateId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the ARM Id of the vCenter resource in which this resource pool resides.
    ${InfrastructureProfileVCenterId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INetworkInterface[]]
    # Gets or sets the list of network interfaces associated with the virtual machine.
    ${NetworkProfileNetworkInterface},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Sets administrator password.
    ${OSProfileAdminPassword},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets administrator username.
    ${OSProfileAdminUsername},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets computer name.
    ${OSProfileComputerName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the guestId.
    ${OSProfileGuestId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PSArgumentCompleterAttribute("Windows", "Linux", "Other")]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the type of the os.
    ${OSProfileOstype},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the ARM Id of the cluster resource on which this virtual machine will deploy.
    ${PlacementProfileClusterId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the ARM Id of the datastore resource on which the data for the virtual machine will be kept.
    ${PlacementProfileDatastoreId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the ARM Id of the host resource on which this virtual machine will deploy.
    ${PlacementProfileHostId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Gets or sets the ARM Id of the resourcePool resource on which this virtual machine will deploy.
    ${PlacementProfileResourcePoolId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk[]]
    # Gets or sets the list of virtual disks associated with the virtual machine.
    ${StorageProfileDisk},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies whether secure boot should be enabled on the virtual machine.
    ${UefiSettingSecureBootEnabled},

    [Parameter(ParameterSetName='CreateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Create operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='CreateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Body')]
    [System.String]
    # Json string supplied to the Create operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Category('Runtime')]
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
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.ConnectedVMware.private\New-AzConnectedVMwareVM_CreateExpanded';
            CreateViaJsonFilePath = 'Az.ConnectedVMware.private\New-AzConnectedVMwareVM_CreateViaJsonFilePath';
            CreateViaJsonString = 'Az.ConnectedVMware.private\New-AzConnectedVMwareVM_CreateViaJsonString';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
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
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
