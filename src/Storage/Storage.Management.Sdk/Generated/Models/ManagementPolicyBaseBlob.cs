// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// Management policy action for base blob.
    /// </summary>
    public partial class ManagementPolicyBaseBlob
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicyBaseBlob class.
        /// </summary>
        public ManagementPolicyBaseBlob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicyBaseBlob class.
        /// </summary>

        /// <param name="tierToCool">The function to tier blobs to cool storage.
        /// </param>

        /// <param name="tierToArchive">The function to tier blobs to archive storage.
        /// </param>

        /// <param name="tierToCold">The function to tier blobs to cold storage.
        /// </param>

        /// <param name="tierToHot">The function to tier blobs to hot storage. This action can only be used
        /// with Premium Block Blob Storage Accounts
        /// </param>

        /// <param name="delete">The function to delete the blob
        /// </param>

        /// <param name="enableAutoTierToHotFromCool">This property enables auto tiering of a blob from cool to hot on a blob
        /// access. This property requires
        /// tierToCool.daysAfterLastAccessTimeGreaterThan.
        /// </param>
        public ManagementPolicyBaseBlob(DateAfterModification tierToCool = default(DateAfterModification), DateAfterModification tierToArchive = default(DateAfterModification), DateAfterModification tierToCold = default(DateAfterModification), DateAfterModification tierToHot = default(DateAfterModification), DateAfterModification delete = default(DateAfterModification), bool? enableAutoTierToHotFromCool = default(bool?))

        {
            this.TierToCool = tierToCool;
            this.TierToArchive = tierToArchive;
            this.TierToCold = tierToCold;
            this.TierToHot = tierToHot;
            this.Delete = delete;
            this.EnableAutoTierToHotFromCool = enableAutoTierToHotFromCool;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the function to tier blobs to cool storage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tierToCool")]
        public DateAfterModification TierToCool {get; set; }

        /// <summary>
        /// Gets or sets the function to tier blobs to archive storage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tierToArchive")]
        public DateAfterModification TierToArchive {get; set; }

        /// <summary>
        /// Gets or sets the function to tier blobs to cold storage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tierToCold")]
        public DateAfterModification TierToCold {get; set; }

        /// <summary>
        /// Gets or sets the function to tier blobs to hot storage. This action can
        /// only be used with Premium Block Blob Storage Accounts
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tierToHot")]
        public DateAfterModification TierToHot {get; set; }

        /// <summary>
        /// Gets or sets the function to delete the blob
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "delete")]
        public DateAfterModification Delete {get; set; }

        /// <summary>
        /// Gets or sets this property enables auto tiering of a blob from cool to hot
        /// on a blob access. This property requires
        /// tierToCool.daysAfterLastAccessTimeGreaterThan.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableAutoTierToHotFromCool")]
        public bool? EnableAutoTierToHotFromCool {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.TierToCool != null)
            {
                this.TierToCool.Validate();
            }
            if (this.TierToArchive != null)
            {
                this.TierToArchive.Validate();
            }
            if (this.TierToCold != null)
            {
                this.TierToCold.Validate();
            }
            if (this.TierToHot != null)
            {
                this.TierToHot.Validate();
            }
            if (this.Delete != null)
            {
                this.Delete.Validate();
            }
        }
    }
}