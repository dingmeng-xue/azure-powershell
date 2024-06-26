// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Resources.ManagementGroups.Common;
using Microsoft.Azure.Commands.Resources.Models.ManagementGroups;
using Microsoft.Azure.Management.ManagementGroups;
using Microsoft.Azure.Management.ManagementGroups.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Resources.ManagementGroups
{
    /// <summary>
    /// Get-AzManagementGroupNameAvailability Cmdlet
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ManagementGroup" + "NameAvailability", DefaultParameterSetName = Constants.ParameterSetNames.ListParameterSet, SupportsShouldProcess = true), OutputType(typeof(PsManagementGroupNameAvailabilityResult))]
    public class GetAzureRmManagementGroupNameAvailability : AzureManagementGroupsCmdletBase
    {
        [Alias("GroupId")]
        [Parameter(ParameterSetName = Constants.ParameterSetNames.ListParameterSet, Mandatory = true, HelpMessage = Constants.HelpMessages.GroupName, Position = 0)]
        public string GroupName { get; set; }

        public override void ExecuteCmdlet()
        {
            try
            {
                PreregisterSubscription();

                var checkRequest = new CheckNameAvailabilityRequest(name: GroupName, Type.MicrosoftManagementManagementGroups);

                dynamic response = ManagementGroupsApiClient.CheckNameAvailability(checkRequest);

                WriteObject(new PsManagementGroupNameAvailabilityResult(response));
            }
            catch(ErrorResponseException ex)
            {
                Utility.HandleErrorResponseException(ex);
            }
        }
    }
}
