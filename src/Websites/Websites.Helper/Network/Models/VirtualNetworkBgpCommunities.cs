// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.WebApps.Helper.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Bgp Communities sent over ExpressRoute with each route corresponding to
    /// a prefix in this VNET.
    /// </summary>
    public partial class VirtualNetworkBgpCommunities
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkBgpCommunities
        /// class.
        /// </summary>
        public VirtualNetworkBgpCommunities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkBgpCommunities
        /// class.
        /// </summary>
        /// <param name="virtualNetworkCommunity">The BGP community associated
        /// with the virtual network.</param>
        /// <param name="regionalCommunity">The BGP community associated with
        /// the region of the virtual network.</param>
        public VirtualNetworkBgpCommunities(string virtualNetworkCommunity, string regionalCommunity = default(string))
        {
            VirtualNetworkCommunity = virtualNetworkCommunity;
            RegionalCommunity = regionalCommunity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the BGP community associated with the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkCommunity")]
        public string VirtualNetworkCommunity { get; set; }

        /// <summary>
        /// Gets the BGP community associated with the region of the virtual
        /// network.
        /// </summary>
        [JsonProperty(PropertyName = "regionalCommunity")]
        public string RegionalCommunity { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkCommunity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetworkCommunity");
            }
        }
    }
}
