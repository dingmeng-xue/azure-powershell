// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The regions capability.
    /// </summary>
    public partial class RegionsCapability
    {
        /// <summary>
        /// Initializes a new instance of the RegionsCapability class.
        /// </summary>
        public RegionsCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegionsCapability class.
        /// </summary>

        /// <param name="available">The list of region capabilities.
        /// </param>
        public RegionsCapability(System.Collections.Generic.IList<string> available = default(System.Collections.Generic.IList<string>))

        {
            this.Available = available;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the list of region capabilities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "available")]
        public System.Collections.Generic.IList<string> Available {get; set; }
    }
}