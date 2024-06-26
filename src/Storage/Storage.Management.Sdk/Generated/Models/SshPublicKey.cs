// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    public partial class SshPublicKey
    {
        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>
        public SshPublicKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshPublicKey class.
        /// </summary>

        /// <param name="description">Optional. It is used to store the function/usage of the key
        /// </param>

        /// <param name="key">Ssh public key base64 encoded. The format should be: &#39;&lt;keyType&gt; &lt;keyData&gt;&#39;,
        /// e.g. ssh-rsa AAAABBBB
        /// </param>
        public SshPublicKey(string description = default(string), string key = default(string))

        {
            this.Description = description;
            this.Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets optional. It is used to store the function/usage of the key
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets ssh public key base64 encoded. The format should be:
        /// &#39;&lt;keyType&gt; &lt;keyData&gt;&#39;, e.g. ssh-rsa AAAABBBB
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public string Key {get; set; }
    }
}