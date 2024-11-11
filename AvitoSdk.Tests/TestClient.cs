using NUnit.Framework;

namespace AvitoSdk.Tests
{
    public class TestClient : AvitoClient
    {
        public TestClient(string clientAccount, string clientSecret) : base(clientAccount, clientSecret)
        {
            Tracer = TestContext.Progress.WriteLine;
        }
    }
}
