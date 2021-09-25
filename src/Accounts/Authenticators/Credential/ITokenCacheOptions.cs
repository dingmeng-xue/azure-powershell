using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Identity;
using Microsoft.Identity.Client;

namespace Microsoft.Azure.PowerShell.Authenticators.Credential
{
    internal interface ITokenCacheOptions
    {
        TokenCachePersistenceOptions TokenCachePersistenceOptions { get; }
    }
}
