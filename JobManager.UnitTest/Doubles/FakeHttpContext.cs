using System.Web;

namespace JobManager.UnitTest.Doubles
{
    public class FakeHttpContext : HttpContextBase
    {
        private readonly string _method;
        private readonly string _relativeUrl;

        public FakeHttpContext(string method, string relativeUrl)
        {
            _method = method;
            _relativeUrl = relativeUrl;
        }

        public override HttpRequestBase Request
        {
            get { return new FakeHttpRequest(_relativeUrl, _method); }
        }

    }
}