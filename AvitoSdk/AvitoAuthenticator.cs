using AvitoSdk.DataContracts;
using Restub;

namespace AvitoSdk
{
    /// <summary>
    /// Avito API authenticator using credentials.
    /// </summary>
    internal class AvitoAuthenticator : Authenticator<AvitoClient, AvitoAuthToken>
    {
        public AvitoAuthenticator(AvitoClient apiClient, AvitoCredentials credentials)
            : base(apiClient, credentials)
        {
        }

        public override void InitAuthHeaders(AvitoAuthToken authToken) =>
            AuthHeaders["Authorization"] = $"Bearer {authToken.AccessToken}";
    }
}
