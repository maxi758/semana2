namespace primeraSolucion
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(55, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += LblApellido_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(52, 100);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.Click += LblApellido_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(139, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(52, 159);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento";
            lblDocumento.Click += Label_Documento_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(139, 151);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.System;
            btnIngresar.Location = new Point(373, 45);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(143, 48);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.Location = new Point(373, 132);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(122, 58);
            btLimpiar.TabIndex = 7;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += BtnLimpiar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIMER PROYECTO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btLimpiar;
    }
}