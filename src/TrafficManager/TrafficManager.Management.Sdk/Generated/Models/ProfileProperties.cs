// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using System.Linq;

    /// <summary>
    /// Class representing the Traffic Manager profile properties.
    /// </summary>
    public partial class ProfileProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProfileProperties class.
        /// </summary>
        public ProfileProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProfileProperties class.
        /// </summary>

        /// <param name="profileStatus">The status of the Traffic Manager profile.
        /// Possible values include: 'Enabled', 'Disabled'</param>

        /// <param name="trafficRoutingMethod">The traffic routing method of the Traffic Manager profile.
        /// Possible values include: 'Performance', 'Priority', 'Weighted',
        /// 'Geographic', 'MultiValue', 'Subnet'</param>

        /// <param name="dnsConfig">The DNS settings of the Traffic Manager profile.
        /// </param>

        /// <param name="monitorConfig">The endpoint monitoring settings of the Traffic Manager profile.
        /// </param>

        /// <param name="endpoints">The list of endpoints in the Traffic Manager profile.
        /// </param>

        /// <param name="trafficViewEnrollmentStatus">Indicates whether Traffic View is &#39;Enabled&#39; or &#39;Disabled&#39; for the Traffic
        /// Manager profile. Null, indicates &#39;Disabled&#39;. Enabling this feature will
        /// increase the cost of the Traffic Manage profile.
        /// Possible values include: 'Enabled', 'Disabled'</param>

        /// <param name="allowedEndpointRecordTypes">The list of allowed endpoint record types.
        /// </param>

        /// <param name="maxReturn">Maximum number of endpoints to be returned for MultiValue routing type.
        /// </param>
        public ProfileProperties(string profileStatus = default(string), string trafficRoutingMethod = default(string), DnsConfig dnsConfig = default(DnsConfig), MonitorConfig monitorConfig = default(MonitorConfig), System.Collections.Generic.IList<Endpoint> endpoints = default(System.Collections.Generic.IList<Endpoint>), string trafficViewEnrollmentStatus = default(string), System.Collections.Generic.IList<string> allowedEndpointRecordTypes = default(System.Collections.Generic.IList<string>), long? maxReturn = default(long?))

        {
            this.ProfileStatus = profileStatus;
            this.TrafficRoutingMethod = trafficRoutingMethod;
            this.DnsConfig = dnsConfig;
            this.MonitorConfig = monitorConfig;
            this.Endpoints = endpoints;
            this.TrafficViewEnrollmentStatus = trafficViewEnrollmentStatus;
            this.AllowedEndpointRecordTypes = allowedEndpointRecordTypes;
            this.MaxReturn = maxReturn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the status of the Traffic Manager profile. Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "profileStatus")]
        public string ProfileStatus {get; set; }

        /// <summary>
        /// Gets or sets the traffic routing method of the Traffic Manager profile. Possible values include: &#39;Performance&#39;, &#39;Priority&#39;, &#39;Weighted&#39;, &#39;Geographic&#39;, &#39;MultiValue&#39;, &#39;Subnet&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "trafficRoutingMethod")]
        public string TrafficRoutingMethod {get; set; }

        /// <summary>
        /// Gets or sets the DNS settings of the Traffic Manager profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dnsConfig")]
        public DnsConfig DnsConfig {get; set; }

        /// <summary>
        /// Gets or sets the endpoint monitoring settings of the Traffic Manager
        /// profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "monitorConfig")]
        public MonitorConfig MonitorConfig {get; set; }

        /// <summary>
        /// Gets or sets the list of endpoints in the Traffic Manager profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endpoints")]
        public System.Collections.Generic.IList<Endpoint> Endpoints {get; set; }

        /// <summary>
        /// Gets or sets indicates whether Traffic View is &#39;Enabled&#39; or &#39;Disabled&#39; for
        /// the Traffic Manager profile. Null, indicates &#39;Disabled&#39;. Enabling this
        /// feature will increase the cost of the Traffic Manage profile. Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "trafficViewEnrollmentStatus")]
        public string TrafficViewEnrollmentStatus {get; set; }

        /// <summary>
        /// Gets or sets the list of allowed endpoint record types.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowedEndpointRecordTypes")]
        public System.Collections.Generic.IList<string> AllowedEndpointRecordTypes {get; set; }

        /// <summary>
        /// Gets or sets maximum number of endpoints to be returned for MultiValue
        /// routing type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxReturn")]
        public long? MaxReturn {get; set; }
    }
}