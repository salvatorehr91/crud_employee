namespace ConsumeWS
{
    public class Employee
    {
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }
        public string fechaN { get; set; }
        public bool status { get; set; }
        public string areaemp { get; set; }
    }

    public class Cred
    {
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }
        public string fechaN { get; set; }
        public bool status { get; set; }
        public string areaemp { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
    }

    #region Respuesta POST/DELETE/PUT
    public class ResponseWS
    {
        public string response { get; set; }
        public Detail detail { get; set; }
    }

    public class Detail
    {
        public int typeError { get; set; }
        public string message { get; set; }
    }
    #endregion

    #region Respuesta GET
    public class RespConEmp
    {
        public string ConsultaEmpResult { get; set; }
    }
    #endregion
}