using AvitoSdk.DataContracts;
using RestSharp;
using Restub.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvitoSdk
{
    /// <remarks>
    /// Avito API Client, athentication primitives.
    /// </remarks>
    public partial class AvitoClient
    {
        /// <summary>
        /// Acquires a JWT token for the Avito API.
        /// </summary>
        /// <param name="clientAccount">Account identifier.</param>
        /// <param name="clientSecret">Client secret or password.</param>
        internal AvitoAuthToken GetAuthToken(string clientAccount, string clientSecret)
        {
            var body = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}", clientAccount, clientSecret);
            var req = new RestRequest();

           //// return Post<AvitoAuthToken>("token", body, r => AddAuthQueryString(r, req));
            return Post<AvitoAuthToken>("token/", body, r =>
            {
                InitAuthRequest(r);
                //r.AlwaysMultipartFormData = true;
            });
        }

        public void InitAuthRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-type", "application/x-www-form-urlencoded");
            initReq.AddHeader("Accept", "application/json");
        }

        public void AddAuthQueryString(object req, IRestRequest initReq)
        {
            InitAuthRequest(initReq);
            initReq.AddQueryString(req);
        }
    }
}
