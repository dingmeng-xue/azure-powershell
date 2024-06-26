
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
Create a in-memory object for NetworkInterface
.Description
Create a in-memory object for NetworkInterface

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterface
.Link
https://learn.microsoft.com/powershell/module/az.ConnectedNetwork/new-AzConnectedNetworkInterfaceObject
#>
function New-AzConnectedNetworkInterfaceObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterface')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="A list of IP configurations of the network interface.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkInterfaceIPConfiguration[]]
        $IPConfiguration,
        [Parameter(HelpMessage="The MAC address of the network interface.")]
        [string]
        $MacAddress,
        [Parameter(HelpMessage="The name of the network interface.")]
        [string]
        $Name,
        [Parameter(HelpMessage="The type of the VM switch.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.VMSwitchType]
        $VMSwitchType
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterface]::New()

        $Object.IPConfiguration = $IPConfiguration
        $Object.MacAddress = $MacAddress
        $Object.Name = $Name
        $Object.VMSwitchType = $VMSwitchType
        return $Object
    }
}

