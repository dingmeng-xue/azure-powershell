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

using Microsoft.Azure.Commands.Maintenance.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Maintenance;
using Microsoft.Azure.Management.Maintenance.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Maintenance
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ConfigurationAssignment", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(bool))]
    public partial class RemoveAzureRmConfigurationAssignment : MaintenanceAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.ConfigurationAssignmentName, VerbsCommon.Remove)
                    && (this.Force.IsPresent ||
                        this.ShouldContinue(Properties.Resources.ResourceRemovalConfirmation,
                                            "Remove-AzConfigurationAssignment operation")))
                {
                    string resourceGroupName = this.ResourceGroupName;
                    string providerName = this.ProviderName;
                    string resourceParentType = this.ResourceParentType;
                    string resourceParentName = this.ResourceParentName;
                    string resourceType = this.ResourceType;
                    string resourceName = this.ResourceName;
                    string configurationAssignmentName = this.ConfigurationAssignmentName;

                    if (IsSubcriptionAssignment(this.ResourceGroupName, this.ProviderName, this.ResourceParentType, this.ResourceName))
                    {
                        this.ConfigurationAssignmentsForSubscriptionsClient.Delete(this.ConfigurationAssignmentName);
                    }
                    else if (IsResourceGroupAssignment(this.ResourceGroupName, this.ProviderName, this.ResourceParentType, this.ResourceName))
                    {
                        this.ConfigurationAssignmentsForResourceGroupClient.Delete(this.ResourceGroupName, this.ConfigurationAssignmentName);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(resourceParentType) && !string.IsNullOrEmpty(resourceParentName))
                        {
                            ConfigurationAssignmentsClient.DeleteParent(resourceGroupName, providerName, resourceParentType, resourceParentName, resourceType, resourceName, configurationAssignmentName);
                        }
                        else
                        {
                            ConfigurationAssignmentsClient.Delete(resourceGroupName, providerName, resourceType, resourceName, configurationAssignmentName);
                        }
                    }

                    if (this.PassThru.IsPresent)
                    {
                        this.WriteObject(true);
                    }
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = false,
            HelpMessage = "The resource Group Name.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = false,
            HelpMessage = "The resource provider Name.",
            ValueFromPipelineByPropertyName = true)]
        public string ProviderName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Mandatory = false,
            HelpMessage = "The parent resource type.",
            ValueFromPipelineByPropertyName = true)]
        public string ResourceParentType { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Mandatory = false,
            HelpMessage = "The parent resource name.",
            ValueFromPipelineByPropertyName = true)]
        public string ResourceParentName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = false,
            HelpMessage = "The resource type.",
            ValueFromPipelineByPropertyName = true)]
        public string ResourceType { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 3,
            Mandatory = false,
            HelpMessage = "The resource name.",
            ValueFromPipelineByPropertyName = true)]
        public string ResourceName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Mandatory = true,
            HelpMessage = "The configuration assignment name.",
            ValueFromPipelineByPropertyName = true)]
        public string ConfigurationAssignmentName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            HelpMessage = "Force remove without confirmation.",
            Mandatory = false)]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Returns the status of the Remove operation. By default, this cmdlet does not generate any output.")]
        public SwitchParameter PassThru { get; set; }
    }
}
