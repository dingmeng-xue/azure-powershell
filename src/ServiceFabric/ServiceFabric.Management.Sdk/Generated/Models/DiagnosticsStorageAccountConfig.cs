// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System.Linq;

    /// <summary>
    /// The storage account information for storing Service Fabric diagnostic logs.
    /// </summary>
    public partial class DiagnosticsStorageAccountConfig
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticsStorageAccountConfig class.
        /// </summary>
        public DiagnosticsStorageAccountConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticsStorageAccountConfig class.
        /// </summary>

        /// <param name="storageAccountName">The Azure storage account name.
        /// </param>

        /// <param name="protectedAccountKeyName">The protected diagnostics storage key name.
        /// </param>

        /// <param name="protectedAccountKeyName2">The secondary protected diagnostics storage key name. If one of the storage
        /// account keys is rotated the cluster will fallback to using the other.
        /// </param>

        /// <param name="blobEndpoint">The blob endpoint of the azure storage account.
        /// </param>

        /// <param name="queueEndpoint">The queue endpoint of the azure storage account.
        /// </param>

        /// <param name="tableEndpoint">The table endpoint of the azure storage account.
        /// </param>
        public DiagnosticsStorageAccountConfig(string storageAccountName, string protectedAccountKeyName, string blobEndpoint, string queueEndpoint, string tableEndpoint, string protectedAccountKeyName2 = default(string))

        {
            this.StorageAccountName = storageAccountName;
            this.ProtectedAccountKeyName = protectedAccountKeyName;
            this.ProtectedAccountKeyName2 = protectedAccountKeyName2;
            this.BlobEndpoint = blobEndpoint;
            this.QueueEndpoint = queueEndpoint;
            this.TableEndpoint = tableEndpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the Azure storage account name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName {get; set; }

        /// <summary>
        /// Gets or sets the protected diagnostics storage key name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedAccountKeyName")]
        public string ProtectedAccountKeyName {get; set; }

        /// <summary>
        /// Gets or sets the secondary protected diagnostics storage key name. If one
        /// of the storage account keys is rotated the cluster will fallback to using
        /// the other.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedAccountKeyName2")]
        public string ProtectedAccountKeyName2 {get; set; }

        /// <summary>
        /// Gets or sets the blob endpoint of the azure storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "blobEndpoint")]
        public string BlobEndpoint {get; set; }

        /// <summary>
        /// Gets or sets the queue endpoint of the azure storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "queueEndpoint")]
        public string QueueEndpoint {get; set; }

        /// <summary>
        /// Gets or sets the table endpoint of the azure storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tableEndpoint")]
        public string TableEndpoint {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StorageAccountName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StorageAccountName");
            }
            if (this.ProtectedAccountKeyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ProtectedAccountKeyName");
            }
            if (this.BlobEndpoint == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "BlobEndpoint");
            }
            if (this.QueueEndpoint == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "QueueEndpoint");
            }
            if (this.TableEndpoint == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TableEndpoint");
            }






        }
    }
}