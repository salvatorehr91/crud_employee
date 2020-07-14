namespace WcfServiceEx
{
    public class Employee
    {
        /*This is a comment*/
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }
        public string fechaN { get; set; }
        
        // Valida si el empleado está activo o dado de baja
        public bool status { get; set; }
        public string areaemp { get; set; }

        public int user { get; set; }
        public string pass { get; set; }
    }
}
