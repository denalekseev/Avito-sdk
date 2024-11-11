using System.Text;
using AvitoSdk.DataContracts;
using NUnit.Framework;

namespace AvitoSdk.Tests
{
    [TestFixture]
    public class AuthTests
    {
        [Test]
        public void Authenticate()
        {
            var client = new TestClient("","");
            var trace = new StringBuilder();
            client.Tracer += (format, args) => trace.AppendFormat(format, args);

            ////var regions = client.GetStores(new DataContracts.Stores.GetOrdersRequest());
            ////Assert.That(regions, Is.Not.Null);
            ////Assert.That(regions.Items, Is.Not.Null);
            ////Assert.That(regions.Items, Is.GreaterThan(0));

            var log = trace.ToString();
            Assert.That(log, Is.Not.Empty);
        }
    }
}