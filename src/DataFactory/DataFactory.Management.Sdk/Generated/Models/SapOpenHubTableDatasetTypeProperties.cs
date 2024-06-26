// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Sap Business Warehouse Open Hub Destination Table properties.
    /// </summary>
    public partial class SapOpenHubTableDatasetTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the SapOpenHubTableDatasetTypeProperties class.
        /// </summary>
        public SapOpenHubTableDatasetTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapOpenHubTableDatasetTypeProperties class.
        /// </summary>

        /// <param name="openHubDestinationName">The name of the Open Hub Destination with destination type as Database
        /// Table. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="excludeLastRequest">Whether to exclude the records of the last request. The default value is
        /// true. Type: boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="baseRequestId">The ID of request for delta loading. Once it is set, only data with
        /// requestId larger than the value of this property will be retrieved. The
        /// default value is 0. Type: integer (or Expression with resultType integer ).
        /// </param>
        public SapOpenHubTableDatasetTypeProperties(object openHubDestinationName, object excludeLastRequest = default(object), object baseRequestId = default(object))

        {
            this.OpenHubDestinationName = openHubDestinationName;
            this.ExcludeLastRequest = excludeLastRequest;
            this.BaseRequestId = baseRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the Open Hub Destination with destination type as
        /// Database Table. Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "openHubDestinationName")]
        public object OpenHubDestinationName {get; set; }

        /// <summary>
        /// Gets or sets whether to exclude the records of the last request. The
        /// default value is true. Type: boolean (or Expression with resultType
        /// boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "excludeLastRequest")]
        public object ExcludeLastRequest {get; set; }

        /// <summary>
        /// Gets or sets the ID of request for delta loading. Once it is set, only data
        /// with requestId larger than the value of this property will be retrieved.
        /// The default value is 0. Type: integer (or Expression with resultType
        /// integer ).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "baseRequestId")]
        public object BaseRequestId {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.OpenHubDestinationName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "OpenHubDestinationName");
            }



        }
    }
}