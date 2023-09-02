namespace insertaDatos
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDato1 = new Label();
            lblDato2 = new Label();
            btnAceptar = new Button();
            btnCalcular = new Button();
            txtDato1 = new TextBox();
            txtDato2 = new TextBox();
            SuspendLayout();
            // 
            // lblDato1
            // 
            lblDato1.AutoSize = true;
            lblDato1.Location = new Point(31, 34);
            lblDato1.Name = "lblDato1";
            lblDato1.Size = new Size(41, 15);
            lblDato1.TabIndex = 0;
            lblDato1.Text = "Dato 1";
            // 
            // lblDato2
            // 
            lblDato2.AutoSize = true;
            lblDato2.Location = new Point(33, 85);
            lblDato2.Name = "lblDato2";
            lblDato2.Size = new Size(41, 15);
            lblDato2.TabIndex = 1;
            lblDato2.Text = "Dato 2";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(90, 153);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 74);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(90, 250);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 72);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtDato1
            // 
            txtDato1.Location = new Point(148, 29);
            txtDato1.Name = "txtDato1";
            txtDato1.Size = new Size(181, 23);
            txtDato1.TabIndex = 4;
            // 
            // txtDato2
            // 
            txtDato2.Location = new Point(148, 85);
            txtDato2.Name = "txtDato2";
            txtDato2.Size = new Size(181, 23);
            txtDato2.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 396);
            Controls.Add(txtDato2);
            Controls.Add(txtDato1);
            Controls.Add(btnCalcular);
            Controls.Add(btnAceptar);
            Controls.Add(lblDato2);
            Controls.Add(lblDato1);
            Name = "frmPrincipal";
            Text = "INGRESO Y MUESTRA DE DATOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDato1;
        private Label lblDato2;
        private Button btnAceptar;
        private Button btnCalcular;
        private TextBox txtDato1;
        private TextBox txtDato2;
    }
}