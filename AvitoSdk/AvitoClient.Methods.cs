using AvitoSdk.DataContracts;
using AvitoSdk.DataContracts.Documents;
using RestSharp;
using Restub.Toolbox;
using System.Linq;

namespace AvitoSdk
{
    /// <remarks>
    /// Avito API Client, methods.
    /// </remarks>
    public partial class AvitoClient
    {
        /// <summary>
        /// Получить список заказов
        /// https://developers.avito.ru/api-catalog/order-management/documentation#info/poluchenie_zakazov
        /// </summary>
        public GetOrdersResponse GetOrders(DataContracts.Documents.GetOrdersRequest request) =>
            Get<GetOrdersResponse>($"/order-management/1/orders", r => AddQueryString(request, r));

        public void InitRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-Type", "application/json");
            initReq.AddHeader("Accept", "application/json");
        }

        public void AddQueryString(DataContracts.Documents.GetOrdersRequest req, IRestRequest initReq)
        {
            InitRequest(initReq);

            initReq.AddQueryParameter("page", req.Page.ToString());

            if (req.Statuses != null && req.Statuses.Any())
            {
                foreach (var item in req.Statuses.Where(r => !string.IsNullOrWhiteSpace(r)))
                {
                    initReq.AddQueryParameter("statuses", item);
                }
            }
            ////initReq.AddQueryString(req);
        }
    }
}