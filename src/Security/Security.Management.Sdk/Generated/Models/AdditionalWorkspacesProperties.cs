// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the additional workspaces.
    /// </summary>
    public partial class AdditionalWorkspacesProperties
    {
        /// <summary>
        /// Initializes a new instance of the AdditionalWorkspacesProperties class.
        /// </summary>
        public AdditionalWorkspacesProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdditionalWorkspacesProperties class.
        /// </summary>

        /// <param name="workspace">Workspace resource id
        /// </param>

        /// <param name="type">Workspace type.
        /// Possible values include: 'Sentinel'</param>

        /// <param name="dataTypes">List of data types sent to workspace
        /// </param>
        public AdditionalWorkspacesProperties(string workspace = default(string), string type = default(string), System.Collections.Generic.IList<string> dataTypes = default(System.Collections.Generic.IList<string>))

        {
            this.Workspace = workspace;
            this.Type = type;
            this.DataTypes = dataTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets workspace resource id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workspace")]
        public string Workspace {get; set; }

        /// <summary>
        /// Gets or sets workspace type. Possible values include: &#39;Sentinel&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets list of data types sent to workspace
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataTypes")]
        public System.Collections.Generic.IList<string> DataTypes {get; set; }
    }
}