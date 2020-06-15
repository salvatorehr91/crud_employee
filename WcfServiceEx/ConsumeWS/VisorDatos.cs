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
        string nombre; string apaterno; string amaterno; string fechaN; string areaemp; string status;
        private Employee dataEmp = new Employee();
        private Cred cr = new Cred();
        private ReqServicioRest reqServ = new ReqServicioRest();

        public void LlenaDatos(Cred emp, bool stat)
        {
            if (!stat)
            {
                btAgregar.Visible = false;
                tbStatus.ReadOnly = true;

                nombre = emp.nombre;
                apaterno = emp.apaterno;
                amaterno = emp.amaterno;
                fechaN = emp.fechaN;
                areaemp = emp.areaemp;
                status = emp.status.ToString();

                tbNombre.Text = nombre;
                tbAPaterno.Text = apaterno;
                tbAMaterno.Text = amaterno;
                tbFNace.Text = fechaN;
                tbArea.Text = areaemp;
                tbStatus.Text = status;

                cr = emp;
            }
            else
            {
                tbStatus.ReadOnly = false;
                btActualizar.Visible = false;
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            dataEmp.nombre = tbNombre.Text.ToUpper();
            dataEmp.apaterno = tbAPaterno.Text;
            dataEmp.amaterno = tbAMaterno.Text.ToUpper();
            dataEmp.fechaN = tbFNace.Text.ToUpper();
            dataEmp.areaemp = tbArea.Text.ToUpper();
            dataEmp.status = Convert.ToBoolean(tbStatus.Text);

            var armaJson = JsonRequest(dataEmp, cr);
            try
            {
                string sURL = string.Format("http://localhost:57008/Example.svc/Update");
                reqServ.Method = "PUT";
                reqServ.ContentType = "application/json";
                var resp = reqServ.CalltoRestPost(armaJson, sURL);

                var jSonR = JsonConvert.DeserializeObject<ResponseWS>(resp);
                MessageBox.Show("Credenciales: " + jSonR.response);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:\n" + ex.Message);
            }
            Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            dataEmp.nombre = tbNombre.Text.ToUpper();
            dataEmp.apaterno = tbAPaterno.Text;
            dataEmp.amaterno = tbAMaterno.Text.ToUpper();
            dataEmp.fechaN = tbFNace.Text.ToUpper();
            dataEmp.areaemp = tbArea.Text.ToUpper();
            if (tbStatus.Text == "A")
                dataEmp.status = true;
            else
                dataEmp.status = false;

            var armaJson = JsonRequest(dataEmp, cr);
            try
            {
                string sURL = string.Format("http://localhost:57008/Example.svc/Create");
                reqServ.Method = "POST";
                reqServ.ContentType = "application/json";
                var resp = reqServ.CalltoRestPost(armaJson, sURL);
                resp = resp.Replace("\\", "").Replace("\"{", "{").Replace("}\"", "}");
                var jSonR = JsonConvert.DeserializeObject<ResponseWS>(resp);
                MessageBox.Show("Credenciales: " + jSonR.response);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:\n" + ex.Message);
            }
            Close();
        }

        private static string JsonRequest(Employee emp, Cred cr)
        {
            try
            {
                if (string.IsNullOrEmpty(cr.pass))
                {
                    var json = new Employee()
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
                    var json = new Cred()
                    {
                        nombre = cr.nombre,
                        apaterno = cr.apaterno,
                        amaterno = cr.amaterno,
                        fechaN = cr.fechaN,
                        areaemp = cr.areaemp,
                        status = cr.status,
                        user = cr.user,
                        pass = cr.pass
                    };
                    return JsonConvert.SerializeObject(json);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            var user = cr.user;
            var contra = cr.pass;
            string sURL = string.Format("http://localhost:57008/Example.svc/Elimina/{0}-{1}", user, contra);
            reqServ.Method = "DELETE";
            reqServ.ContentType = "application/json";
            var response = reqServ.CalltoRest(sURL);

            var respBaja = JsonConvert.DeserializeObject<BajaEmp>(response);

            MessageBox.Show("Respuesta: " + respBaja.BajaEmpResult);
            Close();
        }
    }

    public class BajaEmp
    {
        public string BajaEmpResult { get; set; }
    }
}
