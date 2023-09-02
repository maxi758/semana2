namespace primeraSolucion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the data from the form
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = txtDocumento.Text;
            //create the object
            Persona persona = new Persona(nombre, apellido, documento);
            //show the data
            MessageBox.Show(persona.ToString());
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //clean the form
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
        }

        private void LblApellido_Click(object sender, EventArgs e)
        {


        }

        private void Label_Documento_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}