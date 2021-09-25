// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    /// <summary>
    /// Data regarding an update of a token cache.
    /// </summary>
    public class AzPSTokenCacheUpdatedArgs
    {
        public AzPSTokenCacheUpdatedArgs(ReadOnlyMemory<byte> cacheData)
        {
            UnsafeCacheData = cacheData;
        }

        /// <summary>
        /// The <see cref="TokenCachePersistenceOptions"/> instance which was updated.
        /// </summary>
        public ReadOnlyMemory<byte> UnsafeCacheData { get; }
    }
}