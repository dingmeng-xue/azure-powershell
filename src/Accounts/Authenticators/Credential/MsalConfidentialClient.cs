using Microsoft.Identity.Client;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.PowerShell.Authenticators.Credential
{
    internal class MsalConfidentialClient : MsalClientBase<IConfidentialClientApplication>
    {
        private readonly string _clientSecret;

        /// <summary>
        /// For mocking purposes only.
        /// </summary>
        protected MsalConfidentialClient()
            : base()
        {
        }

        public MsalConfidentialClient(CredentialPipeline pipeline, string tenantId, string clientId, string clientSecret, ITokenCacheOptions cacheOptions)
            : base(pipeline, tenantId, clientId, cacheOptions)
        {
            _clientSecret = clientSecret;
        }

        protected override ValueTask<IConfidentialClientApplication> CreateClientAsync(bool async, CancellationToken cancellationToken)
        {
            ConfidentialClientApplicationBuilder confClientBuilder = ConfidentialClientApplicationBuilder
                .Create(ClientId)
                .WithClientAssertion(_clientSecret)
                .WithTenantId(TenantId);
                //.WithClientSecret(_clientSecret)
                //.WithAuthority(Pipeline.AuthorityHost.AbsoluteUri, TenantId);

            return new ValueTask<IConfidentialClientApplication>(confClientBuilder.Build());
        }

        public virtual async ValueTask<AuthenticationResult> AcquireTokenForClientAsync(string[] scopes, bool async, CancellationToken cancellationToken)
        {
            IConfidentialClientApplication client = await GetClientAsync(async, cancellationToken).ConfigureAwait(false);

            return await client.AcquireTokenForClient(scopes).WithSendX5C(false).ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
