using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace ConsumeWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ReqServicioRest reqServ = new ReqServicioRest();
        private Employee dataEmp = new Employee();
        private Cred crEmp = new Cred();
        private VisorDatos vData = new VisorDatos();

        private void btAceptar_Click(object sender, EventArgs e)
        {
            var user = tbUser.Text;
            var contra = tbContra.Text;
            string sURL = string.Format("http://localhost:57008/Example.svc/Consulta/{0}-{1}", tbUser.Text, tbContra.Text);
            reqServ.Method = "GET";
            reqServ.ContentType = "application/json";
            var response = reqServ.CalltoRest(sURL);

            var respConEmp = JsonConvert.DeserializeObject<RespConEmp>(response);
            var dataEmp = JsonConvert.DeserializeObject<Cred>(respConEmp.ConsultaEmpResult);

            if (!string.IsNullOrEmpty(dataEmp.nombre))
            {
                vData.LlenaDatos(dataEmp, false);
                vData.Show();
            }
            else
                MessageBox.Show("No se encontró resultados.");
        }
        
        private void btNewData_Click(object sender, EventArgs e)
        {
            vData.LlenaDatos(crEmp, true);
            vData.Show();
        }
    }
}
