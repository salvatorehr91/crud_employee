using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsumeWS
{
    public class ReqServicioRest
    {
        public string Method { get; set; }
        public string ContentType { get; set; }

        public string CalltoRest(string myUrl)
        {
            string respWS = string.Empty;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(myUrl);
                request.Method = Method;
                request.ContentType = ContentType;
                request.Accept = ContentType;

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return "Unaccess";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            respWS = objReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                respWS = ex.Message;
            }
            return respWS;
        }

        public string CalltoRestPost(string postData, string myUrl)
        {
            string resp = string.Empty;
            try
            {
                HttpWebRequest req = WebRequest.Create(myUrl) as HttpWebRequest;
                req.Method = Method;
                req.ContentType = ContentType;
                
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myUrl);
                request.Method = Method;
                request.ContentType = ContentType;
                request.Timeout = 10000;
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();
                resp = new StreamReader(response.GetResponseStream()).ReadToEnd();

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
    }
}
