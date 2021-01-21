// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.WebApps.Helper.PrivateDns.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response to a Private DNS zone list operation.
    /// </summary>
    public partial class PrivateZoneListResult
    {
        /// <summary>
        /// Initializes a new instance of the PrivateZoneListResult class.
        /// </summary>
        public PrivateZoneListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateZoneListResult class.
        /// </summary>
        /// <param name="value">Information about the Private DNS
        /// zones.</param>
        /// <param name="nextLink">The continuation token for the next page of
        /// results.</param>
        public PrivateZoneListResult(IList<PrivateZone> value = default(IList<PrivateZone>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about the Private DNS zones.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PrivateZone> Value { get; set; }

        /// <summary>
        /// Gets the continuation token for the next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
