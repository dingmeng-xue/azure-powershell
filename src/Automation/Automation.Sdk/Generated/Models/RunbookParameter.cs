// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the runbook parameter type.
    /// </summary>
    public partial class RunbookParameter
    {
        /// <summary>
        /// Initializes a new instance of the RunbookParameter class.
        /// </summary>
        public RunbookParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunbookParameter class.
        /// </summary>
        /// <param name="type">Gets or sets the type of the parameter.</param>
        /// <param name="isMandatory">Gets or sets a Boolean value to indicate
        /// whether the parameter is mandatory or not.</param>
        /// <param name="position">Get or sets the position of the
        /// parameter.</param>
        /// <param name="defaultValue">Gets or sets the default value of
        /// parameter.</param>
        public RunbookParameter(string type = default(string), bool? isMandatory = default(bool?), int? position = default(int?), string defaultValue = default(string))
        {
            Type = type;
            IsMandatory = isMandatory;
            Position = position;
            DefaultValue = defaultValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value to indicate whether the parameter is
        /// mandatory or not.
        /// </summary>
        [JsonProperty(PropertyName = "isMandatory")]
        public bool? IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets get or sets the position of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets the default value of parameter.
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

    }
}
