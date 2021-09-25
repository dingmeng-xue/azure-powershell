using Microsoft.Identity.Client;

namespace Microsoft.Azure.PowerShell.Authenticators.Credential
{
    internal class AuthenticationAccount : IAccount
    {
        private AzPSAuthRecord _profile;

        internal AuthenticationAccount(AzPSAuthRecord profile)
        {
            _profile = profile;
        }

        string IAccount.Username => _profile.Username;

        string IAccount.Environment => _profile.Authority;

        AccountId IAccount.HomeAccountId => _profile.AccountId;

        public static explicit operator AuthenticationAccount(AzPSAuthRecord profile) => new AuthenticationAccount(profile);
        public static explicit operator AzPSAuthRecord(AuthenticationAccount account) => account._profile;
    }
}
