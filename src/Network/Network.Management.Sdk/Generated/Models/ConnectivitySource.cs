// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters that define the source of the connection.
    /// </summary>
    public partial class ConnectivitySource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivitySource class.
        /// </summary>
        public ConnectivitySource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivitySource class.
        /// </summary>

        /// <param name="resourceId">The ID of the resource from which a connectivity check will be initiated.
        /// </param>

        /// <param name="port">The source port from which a connectivity check will be performed.
        /// </param>
        public ConnectivitySource(string resourceId, int? port = default(int?))

        {
            this.ResourceId = resourceId;
            this.Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the ID of the resource from which a connectivity check will be
        /// initiated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId {get; set; }

        /// <summary>
        /// Gets or sets the source port from which a connectivity check will be
        /// performed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "port")]
        public int? Port {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ResourceId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ResourceId");
            }

            if (this.Port != null)
            {
                if (this.Port > 65535)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "Port", 65535);
                }
                if (this.Port < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "Port", 0);
                }
            }
        }
    }
}