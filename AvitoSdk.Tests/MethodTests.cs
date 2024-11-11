using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AvitoSdk.DataContracts;
using NUnit.Framework;

namespace AvitoSdk.Tests
{
    [TestFixture]
    public class MethodTests
    {
        private TestClient Client { get; } = new TestClient("", "");

        [Test, Ordered]
        public void GetStores()
        {
            var regions = Client.GetOrders(new DataContracts.Documents.GetOrdersRequest(), null);
            Assert.That(regions, Is.Not.Null);
            ////Assert.That(regions, Is.Not.Null);
            ////Assert.That(regions.Items.Count, Is.GreaterThan(0));
        }
    }
}