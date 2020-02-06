﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.CosmosDB.Models;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.CosmosDB.Models
{
    public class PSMongoIndexKeys
    {
        public PSMongoIndexKeys()
        {
        }

        public PSMongoIndexKeys(MongoIndexKeys mongoIndexKeys)
        {
            Keys = mongoIndexKeys.Keys;
        }

        static public MongoIndexKeys ConvertPSMongoIndexKeysToMongoIndexKeys(PSMongoIndexKeys psMongoIndexKeys)
        {
            return new MongoIndexKeys{ Keys = psMongoIndexKeys.Keys };
        }

        //
        // Summary:
        //     Gets or sets list of keys for each MongoDB collection in the Azure Cosmos DB
        //     service
        public IList<string> Keys { get; set; }
    }
}