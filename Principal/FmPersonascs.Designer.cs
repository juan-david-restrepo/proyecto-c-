namespace Principal
{
    partial class FmPersonascs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCarros = new Button();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            lblDocumento = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            tbDocumento = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            SuspendLayout();
            // 
            // btnCarros
            // 
            btnCarros.Location = new Point(355, 357);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(75, 23);
            btnCarros.TabIndex = 17;
            btnCarros.Text = "Carros";
            btnCarros.UseVisualStyleBackColor = true;
            btnCarros.Click += btnCarros_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(403, 311);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(105, 27);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(292, 311);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(105, 27);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblDocumento
            // 
            lblDocumento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(292, 148);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 14;
            lblDocumento.Text = "Documento";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(292, 225);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(292, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(292, 180);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(216, 23);
            tbDocumento.TabIndex = 11;
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(292, 261);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(216, 23);
            tbTelefono.TabIndex = 10;
            tbTelefono.TextChanged += tbTelefono_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(292, 104);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(216, 23);
            tbNombre.TabIndex = 9;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // FmPersonascs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarros);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblDocumento);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(tbDocumento);
            Controls.Add(tbTelefono);
            Controls.Add(tbNombre);
            Name = "FmPersonascs";
            Text = "FmPersonascs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarros;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblNombre;
        private TextBox tbDocumento;
        private TextBox tbTelefono;
        private TextBox tbNombre;
    }
}