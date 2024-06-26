// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// The call rate limit Cognitive Services account.
    /// </summary>
    public partial class RegionSetting
    {
        /// <summary>
        /// Initializes a new instance of the RegionSetting class.
        /// </summary>
        public RegionSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegionSetting class.
        /// </summary>

        /// <param name="name">Name of the region.
        /// </param>

        /// <param name="value">A value for priority or weighted routing methods.
        /// </param>

        /// <param name="customsubdomain">Maps the region to the regional custom subdomain.
        /// </param>
        public RegionSetting(string name = default(string), double? value = default(double?), string customsubdomain = default(string))

        {
            this.Name = name;
            this.Value = value;
            this.Customsubdomain = customsubdomain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the region.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets a value for priority or weighted routing methods.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public double? Value {get; set; }

        /// <summary>
        /// Gets or sets maps the region to the regional custom subdomain.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "customsubdomain")]
        public string Customsubdomain {get; set; }
    }
}