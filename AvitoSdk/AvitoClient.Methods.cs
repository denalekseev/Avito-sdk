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
        public GetOrdersResponse GetOrders(DataContracts.Documents.GetOrdersRequest request, string[] statuses) =>
            Get<GetOrdersResponse>($"/order-management/1/orders", r => AddQueryString(request, r, statuses));

        public void InitRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-Type", "application/json");
            initReq.AddHeader("Accept", "application/json");
        }

        public void AddQueryString(DataContracts.Documents.GetOrdersRequest req, IRestRequest initReq, string[] statuses)
        {
            InitRequest(initReq);

            initReq.AddQueryParameter("page", req.Page.ToString());
            initReq.AddQueryString(req);

            if (statuses != null && statuses.Any())
            {
                foreach (var item in statuses.Where(r => !string.IsNullOrWhiteSpace(r)))
                {
                    initReq.AddQueryParameter("statuses", item);
                }
            }
        }
    }
}