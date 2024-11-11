using System;
using System.Collections.Generic;
using System.Linq;
using AvitoSdk.DataContracts;
using AvitoSdk.Toolbox;
using RestSharp;
using RestSharp.Authenticators;
using Restub;
using Restub.DataContracts;

namespace AvitoSdk
{
    /// <summary>
    /// Avito API Client.
    /// </summary>
    public partial class AvitoClient : RestubClient
    {
        /// <summary>
        /// Production API endpoint.
        /// </summary>
        public const string ProductionApiUrl = "https://api.avito.ru/";

        /// <summary>
        /// Initializes a new instance of the <see cref="AvitoClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base API endpoint.</param>
        /// <param name="credentials">Credentials.</param>
        public AvitoClient(string baseUrl, AvitoCredentials credentials)
            : base(baseUrl, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvitoClient"/> class.
        /// </summary>
        /// <param name="сlient">REST API client.</param>
        /// <param name="credentials">Credentials.</param>
        public AvitoClient(string baseUrl, string clientAccount, string clientSecret)
            : base(baseUrl, new AvitoCredentials(clientAccount, clientSecret))
        {
        }

        public AvitoClient(string clientAccount, string clientSecret)
            : base(ProductionApiUrl, new AvitoCredentials(clientAccount, clientSecret))
        {
        }

        /// <inheritdoc/>
        public override string LibraryName =>
            $"{nameof(AvitoSdk)}.{nameof(AvitoClient)} v{LibraryVersion}, {base.LibraryName}";

        /// <inheritdoc/>
        protected override IAuthenticator GetAuthenticator() =>
            new AvitoAuthenticator(this, (AvitoCredentials)Credentials);

        /// <inheritdoc/>
        protected override IRestubSerializer CreateSerializer() =>
            new AvitoSerializer();

        /// <inheritdoc/>
        protected override Exception CreateException(IRestResponse res, string msg, IHasErrors errors) =>
            new AvitoException(res.StatusCode, msg, base.CreateException(res, msg, errors))
            {
                ErrorResponseText = res.Content,
            };
    }
}