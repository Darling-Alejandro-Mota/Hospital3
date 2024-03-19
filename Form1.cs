namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Distribuir_Click(object sender, EventArgs e)
        {

            Double Presupuesto, Emergencias, Cirugia, Suministros, Administracion, Laboratorio, Imagenes;

            Presupuesto = Double.Parse(txt_Presupuesto.Text);


            Emergencias = (Presupuesto * 30) / 100;
            Cirugia = (Presupuesto * 15) / 100;
            Suministros = (Presupuesto * 25) / 100;
            Administracion = (Presupuesto * 18) / 100;
            Laboratorio = (Presupuesto * 5) / 100;
            Imagenes = (Presupuesto * 7) / 100;

            txt_Emergencias.Text = Emergencias.ToString();
            txt_Cirugia.Text = Cirugia.ToString();
            txt_Suministros.Text = Suministros.ToString();
            txt_Administracion.Text = Administracion.ToString();
            txt_Laboratorio.Text = Laboratorio.ToString();
            txt_Imagenes.Text = Imagenes.ToString();

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

            txt_Emergencias.Clear();
            txt_Cirugia.Clear();
            txt_Suministros.Clear();
            txt_Administracion.Clear();
            txt_Laboratorio.Clear();
            txt_Imagenes.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
