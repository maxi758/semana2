namespace insertaDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtDato1.Text + " " + txtDato2.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            string strNum1 = "";
            string strNum2 = "";
            strNum1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero", "Numero 1", "0");
            strNum2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese otro numero", "Numero 2", "0");
            num1 = Convert.ToInt32(strNum1);
            num2 = Convert.ToInt32(strNum2);
            if (num1 > num2)
            {
                MessageBox.Show($"{num1} es mas grande que {num2}");
            }
            else if (num1 < num2)
            {
                MessageBox.Show($"{num2} es mas grande que {num1}");
            }
            else
            {
                MessageBox.Show($"Los numeros son iguales");
            }
        }
    }
}