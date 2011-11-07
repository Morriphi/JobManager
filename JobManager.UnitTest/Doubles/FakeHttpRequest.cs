using System;
using System.Web;

namespace JobManager.UnitTest.Doubles
{
    public class FakeHttpRequest : HttpRequestBase
    {
        private readonly string _relativeUrl;
        private readonly string _method;

        public FakeHttpRequest(string relativeUrl, string method)
        {
            _relativeUrl = relativeUrl;
            _method = method;
        }

        public override string HttpMethod
        {
            get
            {
                return _method;
            }
        }

        public override string AppRelativeCurrentExecutionFilePath
        {
            get
            {
                return _relativeUrl;
            }
        }

        public override string PathInfo
        {
            get { return String.Empty; }
        } 
    }
}