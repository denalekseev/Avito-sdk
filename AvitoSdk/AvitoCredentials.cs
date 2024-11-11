using AvitoSdk.DataContracts;
using Restub;

namespace AvitoSdk
{
    /// <summary>
    /// Avito API Credentials.
    /// </summary>
    public class AvitoCredentials : Credentials<AvitoClient, AvitoAuthToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvitoCredentials"/> class.
        /// </summary>
        public AvitoCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvitoCredentials"/> class.
        /// </summary>
        /// <param name="clientAccount">Client account.</param>
        /// <param name="clientSecret">Client secret.</param>
        public AvitoCredentials(string clientAccount, string clientSecret)
        {
            ClientAccount = clientAccount;
            ClientSecret = clientSecret;
        }

        /// <summary>
        /// Gets or sets client account identifier.
        /// </summary>
        public string ClientAccount { get; set; }

        /// <summary>
        /// Gets or sets client API secret, or password.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Authenticates the client using account/secret pair.
        /// </summary>
        /// <param name="client">API client.</param>
        public override AvitoAuthToken Authenticate(AvitoClient client) =>
            client.GetAuthToken(ClientAccount, ClientSecret);
    }
}
