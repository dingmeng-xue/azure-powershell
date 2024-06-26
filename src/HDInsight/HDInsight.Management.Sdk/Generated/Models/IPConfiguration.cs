// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The ip configurations for the private link service.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class IPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the IPConfiguration class.
        /// </summary>
        public IPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IPConfiguration class.
        /// </summary>

        /// <param name="id">The private link IP configuration id.
        /// </param>

        /// <param name="name">The name of private link IP configuration.
        /// </param>

        /// <param name="type">The type of the private link IP configuration.
        /// </param>

        /// <param name="provisioningState">The private link configuration provisioning state, which only appears in
        /// the response.
        /// Possible values include: &#39;InProgress&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;,
        /// &#39;Deleting&#39;</param>

        /// <param name="primary">Indicates whether this IP configuration is primary for the corresponding
        /// NIC.
        /// </param>

        /// <param name="privateIPAddress">The IP address.
        /// </param>

        /// <param name="privateIPAllocationMethod">The method that private IP address is allocated.
        /// Possible values include: &#39;dynamic&#39;, &#39;static&#39;</param>

        /// <param name="subnet">The subnet resource id.
        /// </param>
        public IPConfiguration(string name, string id = default(string), string type = default(string), string provisioningState = default(string), bool? primary = default(bool?), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), ResourceId subnet = default(ResourceId))

        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.ProvisioningState = provisioningState;
            this.Primary = primary;
            this.PrivateIPAddress = privateIPAddress;
            this.PrivateIPAllocationMethod = privateIPAllocationMethod;
            this.Subnet = subnet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the private link IP configuration id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets or sets the name of private link IP configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets the type of the private link IP configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets the private link configuration provisioning state, which only appears
        /// in the response. Possible values include: &#39;InProgress&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets indicates whether this IP configuration is primary for the
        /// corresponding NIC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary {get; set; }

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress {get; set; }

        /// <summary>
        /// Gets or sets the method that private IP address is allocated. Possible values include: &#39;dynamic&#39;, &#39;static&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod {get; set; }

        /// <summary>
        /// Gets or sets the subnet resource id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnet")]
        public ResourceId Subnet {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }







        }
    }
}