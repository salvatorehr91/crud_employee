using System;
using Newtonsoft.Json;

namespace WcfServiceEx
{
    public class Example : IExample
    {
        private ConsultaDB db = new ConsultaDB();
        public string CreateEmp(Employee data)
        {
            try
            {
                string query = "SPINSEMP '" + data.nombre + "','" + data.apaterno + "','" + data.amaterno + "','" +
                    data.fechaN + "'," + data.status + ",'" + data.areaemp + "'";
                var resp = db.Ejecuta(query);
                
                if (resp.Rows.Count > 0)
                {
                    data.user = Convert.ToInt32(resp.Rows[0].ItemArray[1]);
                    data.pass = resp.Rows[0].ItemArray[2].ToString();
                }
                var x1 = data.user + "-" + data.pass;
                return JsonResponse(x1, "", 200);
            }
            catch (Exception ex)
            {
                return JsonResponse("", ex.Message, 300);
            }
        }

        public string ConsultaEmp(string user, string pass)
        {
            try
            {
                Employee dt = new Employee();

                string query = "SPFINDEMP '" + user + "', '" + pass + "'";
                var resp = db.Ejecuta(query);
                if (resp.Rows.Count > 0)
                {
                    dt.user = Convert.ToInt32(resp.Rows[0].ItemArray[1]);
                    dt.pass = resp.Rows[0].ItemArray[2].ToString();
                    dt.nombre = resp.Rows[0].ItemArray[3].ToString();
                    dt.apaterno = resp.Rows[0].ItemArray[4].ToString();
                    dt.amaterno = resp.Rows[0].ItemArray[5].ToString();
                    dt.fechaN = resp.Rows[0].ItemArray[6].ToString();
                    dt.status = Convert.ToBoolean(resp.Rows[0].ItemArray[7]);
                    dt.areaemp = resp.Rows[0].ItemArray[8].ToString();
                }
                return JsonData(dt);
            }
            catch (Exception ex)
            {
                return JsonResponse("", ex.Message, 300);
            }
        }

        public string BajaEmp(string user, string contra)
        {
            try
            {
                string query = "SPDELEMP '" + user + "', '" + contra + "'";
                var resp = db.Ejecuta(query);
                return "Usuario eliminado";
            }
            catch (Exception ex)
            {
                return JsonResponse("", ex.Message, 300);
            }
        }

        public string ActualizaEmp(Employee data)
        {
            try
            {
                string query = "SPUPDDATAEMP '" + data.nombre + "','" + data.apaterno + "','" + data.amaterno + "','" +
                    data.fechaN + "'," + data.status + ",'" + data.areaemp + "', " + data.user + ", '" + data.pass + "'";
                var resp = db.Ejecuta(query);

                data.user = Convert.ToInt32(resp.Rows[0].ItemArray[1]);
                data.pass = resp.Rows[0].ItemArray[2].ToString();
                data.nombre = resp.Rows[0].ItemArray[3].ToString();
                data.apaterno = resp.Rows[0].ItemArray[4].ToString();
                data.amaterno = resp.Rows[0].ItemArray[5].ToString();
                data.fechaN = resp.Rows[0].ItemArray[6].ToString();
                data.status = Convert.ToBoolean(resp.Rows[0].ItemArray[7]);
                data.areaemp = resp.Rows[0].ItemArray[8].ToString();
                
                return JsonData(data);
            }
            catch (Exception ex)
            {
                return JsonResponse("", ex.Message, 300);
            }
        }

        private static string JsonResponse(string resp, string msg, int tErr)
        {
            try
            {
                var json = new Issue()
                {
                    response = resp,

                    detail = new IssueDetail
                    {
                        typeError = tErr,
                        message = msg
                    }
                };
                return JsonConvert.SerializeObject(json);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static string JsonData(Employee emp)
        {
            try
            {
                var json = new Employee();
                if (!String.IsNullOrEmpty(emp.nombre))
                {
                    json = new Employee()
                    {
                        user = emp.user,
                        pass = emp.pass,
                        nombre = emp.nombre,
                        apaterno = emp.apaterno,
                        amaterno = emp.amaterno,
                        fechaN = emp.fechaN,
                        status = emp.status,
                        areaemp = emp.areaemp
                    };
                }
                else
                {
                    json = new Employee()
                    {
                        user = emp.user,
                        pass = emp.pass
                    };
                }
                return JsonConvert.SerializeObject(json);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
