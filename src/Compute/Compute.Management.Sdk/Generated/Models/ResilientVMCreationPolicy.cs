// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration parameters used while performing resilient VM
    /// creation.
    /// </summary>
    public partial class ResilientVMCreationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ResilientVMCreationPolicy class.
        /// </summary>
        public ResilientVMCreationPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResilientVMCreationPolicy class.
        /// </summary>
        /// <param name="enabled">Specifies whether resilient VM creation
        /// should be enabled on the virtual machine scale set. The default
        /// value is false.</param>
        public ResilientVMCreationPolicy(bool? enabled = default(bool?))
        {
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether resilient VM creation should be
        /// enabled on the virtual machine scale set. The default value is
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}
