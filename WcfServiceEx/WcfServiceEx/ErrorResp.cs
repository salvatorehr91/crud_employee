namespace WcfServiceEx
{
    internal class Issue
    {
        public string response { get; set; }
        public IssueDetail detail { get; set; }
        public Issue()
        {
            response = string.Empty;
            detail = new IssueDetail();
        }
        public Issue(string stControl, IssueDetail detail)
        {
            response = stControl;
            this.detail = detail;
        }
    }
    internal class IssueDetail
    {
        public int typeError { get; set; }
        public string message { get; set; }
        public IssueDetail()
        {
            typeError = 0;
            message = string.Empty;
        }
        public IssueDetail(int typeError, string msgDetail)
        {
            this.typeError = typeError;
            message = msgDetail;
        }
    }
}