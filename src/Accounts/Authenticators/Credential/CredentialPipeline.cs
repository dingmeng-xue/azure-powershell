// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Diagnostics;
using Azure.Core.Pipeline;
using Azure.Identity;
using Microsoft.Identity.Client;

namespace Microsoft.Azure.PowerShell.Authenticators.Credential
{
    internal class CredentialPipeline
    {
        private static readonly Lazy<CredentialPipeline> s_singleton = new Lazy<CredentialPipeline>(() => new CredentialPipeline(new TokenCredentialOptions()));

        private CredentialPipeline(TokenCredentialOptions options)
        {
            AuthorityHost = options.AuthorityHost;

            HttpPipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new CredentialResponseClassifier());
        }

        public static CredentialPipeline GetInstance(TokenCredentialOptions options)
        {
            return options is null ? s_singleton.Value : new CredentialPipeline(options);
        }

        public Uri AuthorityHost { get; }

        public HttpPipeline HttpPipeline { get; }

        private class CredentialResponseClassifier : ResponseClassifier
        {
            public override bool IsRetriableResponse(HttpMessage message)
            {
                return base.IsRetriableResponse(message) || message.Response.Status == 404;
            }
        }
    }
}
