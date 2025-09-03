namespace Principal
{
    partial class FmCarros
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
            tbModelo = new TextBox();
            tbDueño = new TextBox();
            tbPlaca = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            btnConsultar = new Button();
            btnPersonas = new Button();
            SuspendLayout();
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(273, 90);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(216, 23);
            tbModelo.TabIndex = 0;
            tbModelo.TextChanged += tbModelo_TextChanged;
            // 
            // tbDueño
            // 
            tbDueño.Location = new Point(273, 247);
            tbDueño.Name = "tbDueño";
            tbDueño.Size = new Size(216, 23);
            tbDueño.TabIndex = 1;
            // 
            // tbPlaca
            // 
            tbPlaca.Location = new Point(273, 166);
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(216, 23);
            tbPlaca.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(273, 56);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Modelo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(273, 211);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Dueño";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(273, 134);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Placa";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(273, 297);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(105, 27);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(384, 297);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(105, 27);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(344, 346);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(75, 23);
            btnPersonas.TabIndex = 8;
            btnPersonas.Text = "Personas";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // FmCarros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPersonas);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPlaca);
            Controls.Add(tbDueño);
            Controls.Add(tbModelo);
            Name = "FmCarros";
            Text = "FmPersonas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbModelo;
        private TextBox tbDueño;
        private TextBox tbPlaca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private Button btnConsultar;
        private Button btnPersonas;
    }
}