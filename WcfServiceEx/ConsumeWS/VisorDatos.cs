using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace ConsumeWS
{
    public partial class VisorDatos : Form
    {
        public VisorDatos()
        {
            InitializeComponent();
        }

        string userD;
        string passD;
        public Employee cr = new Employee();

        public void LlenaDatos(string user1, string pass1)
        {
            userD = user1;
            passD = pass1;
            tbNombre.Text = cr.nombre;
            tbAPaterno.Text = cr.apaterno;
            tbAMaterno.Text = cr.amaterno;
            dtTimeDate.Text = cr.fechaN;
            tbArea.Text = cr.areaemp;
            cbStatus.Text=cr.status.ToString();
            if (Convert.ToBoolean(cbStatus.Text))
                cbStatus.Text = "ALTA";
            else
                cbStatus.Text = "BAJA";
        }

        private string JsonRequest(Employee emp)
        {
            try
            {
                if (string.IsNullOrEmpty(passD))
                {
                    var json = new DataEmp()
                    {
                        nombre = emp.nombre,
                        apaterno = emp.apaterno,
                        amaterno = emp.amaterno,
                        fechaN = emp.fechaN,
                        areaemp = emp.areaemp,
                        status = emp.status
                    };
                    return JsonConvert.SerializeObject(json);
                }
                else
                {
                    var json = new Employee()
                    {
                        nombre = emp.nombre,
                        apaterno = emp.apaterno,
                        amaterno = emp.amaterno,
                        fechaN = emp.fechaN,
                        areaemp = emp.areaemp,
                        status = emp.status,
                        user = userD,
                        pass = passD
                    };
                    return JsonConvert.SerializeObject(json);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string sURL;
            var dateT = DateTime.Parse(dtTimeDate.Text);
            Employee dataEmp = new Employee();
            dataEmp.nombre = tbNombre.Text.ToUpper();
            dataEmp.apaterno = tbAPaterno.Text;
            dataEmp.amaterno = tbAMaterno.Text.ToUpper();
            dataEmp.fechaN = dateT.Year + "-" + dateT.Month + "-" + dateT.Day;
            dataEmp.areaemp = tbArea.Text.ToUpper();
            
            if (cbStatus.Text == "Alta")
                dataEmp.status = true;
            else if(cbStatus.Text =="Baja")
                dataEmp.status = false;

            var armaJson = JsonRequest(dataEmp);
            try
            {
                ReqServicioRest reqServ = new ReqServicioRest();
                reqServ.ContentType = "application/json";
                
                if (string.IsNullOrEmpty(passD))
                {
                    sURL = string.Format("http://localhost:57008/Example.svc/Create");
                    reqServ.Method = "POST";
                    var resp = reqServ.CalltoRestPost(armaJson, sURL);
                    resp = resp.Replace("\\", "").Replace("\"{", "{").Replace("}\"", "}");
                    var jSonR = JsonConvert.DeserializeObject<ResponseWS>(resp);
                    MessageBox.Show("Credenciales: " + jSonR.response);
                }
                else
                {
                    sURL = string.Format("http://localhost:57008/Example.svc/Update");
                    reqServ.Method = "PUT";
                    var resp = reqServ.CalltoRestPost(armaJson, sURL);
                    resp = resp.Replace("\\", "").Replace("\"{", "{").Replace("}\"", "}");
                    var jSonR = JsonConvert.DeserializeObject<Employee>(resp);
                    string credd = jSonR.user + "-" + jSonR.pass;
                    MessageBox.Show("Credenciales: " + credd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:\n" + ex.Message);
            }
            Close();
        }
    }
}
