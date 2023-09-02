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
            MessageBox.Show($"Dato 1: {txtDato1.Text}" + Environment.NewLine + 
                $"Dato 2: {txtDato2.Text}", "Datos desde el texbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string strNum1 = "";
            string strNum2 = "";
            strNum1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer dato", "Dato 1", "Ingrese");
            strNum2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo dato", "Dato 2", "Ingrese");
            MessageBox.Show($"Dato 1: {strNum1}" + Environment.NewLine +
                $"Dato 2: {strNum2}", "Datos desde el texbox", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            string strNum1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero", "Numero 1", "0");
            string strNum2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese otro numero", "Numero 2", "0");
            bool num1IsValid = Int32.TryParse(strNum1, out num1);
            bool num2IsValid = Int32.TryParse(strNum2, out num2);
            if (!num1IsValid || !num2IsValid)
            {
                MessageBox.Show("Los datos ingresados no son numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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