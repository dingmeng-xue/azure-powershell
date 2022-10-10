﻿// ----------------------------------------------------------------------------------
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

using Azure.Analytics.Synapse.Artifacts.Models;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    public class PSLinkConnectionResource
    {
        public PSLinkConnectionResource(LinkConnectionResource linkConnectionResource, string workspaceName)
        {
            this.WorkspaceName = workspaceName;
            this.Id = linkConnectionResource?.Id;
            this.Name = linkConnectionResource?.Name;
            this.Type = linkConnectionResource?.Type;
            this.Properties = linkConnectionResource?.Properties != null? new PSLinkConnection(linkConnectionResource?.Properties) : null;
            this.Description = linkConnectionResource?.Description;
        }

        public string WorkspaceName { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }   

        public string Type { get; set; }

        public PSLinkConnection Properties { get; set; }

        public string Description { get; set; }
    }
}
