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

        private void btAceptar_Click(object sender, EventArgs e)
        {
            var user = tbUser.Text;
            var contra = tbContra.Text;
            string sURL = string.Format("http://localhost:57008/Example.svc/Consulta/{0}-{1}", user, contra);
            reqServ.Method = "GET";
            reqServ.ContentType = "application/json";
            var response = reqServ.CalltoRest(sURL);

            var respConEmp = JsonConvert.DeserializeObject<RespConEmp>(response);
            var dataEmp = JsonConvert.DeserializeObject<Employee>(respConEmp.ConsultaEmpResult);

            if (!string.IsNullOrEmpty(dataEmp.nombre))
            {
                VisorDatos vData = new VisorDatos();
                vData.cr = dataEmp;
                vData.LlenaDatos(user, contra);
                vData.Show(this);
            }
            else
                MessageBox.Show("No se encontró resultados.");
        }
        
        private void btNewData_Click(object sender, EventArgs e)
        {
            VisorDatos vData = new VisorDatos();
            vData.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.employee' Puede moverla o quitarla según sea necesario.
            //this.employeeTableAdapter.Fill(this.desarrolloDataSet.employee);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ReqServicioRest reqServ = new ReqServicioRest();
                string sURL = string.Format("http://localhost:57008/Example.svc/Elimina/{0}-{1}", tbUser.Text, tbContra.Text);
                reqServ.Method = "DELETE";
                reqServ.ContentType = "application/json";
                var response = reqServ.CalltoRest(sURL);

                var respBaja = JsonConvert.DeserializeObject<BajaEmp>(response);

                MessageBox.Show("Respuesta: " + respBaja.BajaEmpResult);
                UpdateInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateInfo()
        {
            //this.employeeTableAdapter.Fill(this.desarrolloDataSet.employee);
            string query = "select * from employee";
            ConsultaDB db = new ConsultaDB();
            employeeBindingSource.DataSource = db.Ejecuta(query);
        }
    }
}
