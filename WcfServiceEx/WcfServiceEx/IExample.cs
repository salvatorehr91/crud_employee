using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfServiceEx
{
    [ServiceContract]
    public interface IExample
    {
        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="/Create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string CreateEmp(Employee data);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Consulta/{user}-{pass}", BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json)]
        string ConsultaEmp(string user, string pass);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Elimina/{user}-{pass}", BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json)]
        string BajaEmp(string user, string pass);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/Update", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string ActualizaEmp(Employee data);
    }
}
