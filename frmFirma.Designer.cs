namespace pryLab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirmar = new Label();
            BtnLimpiar = new Button();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFirmar
            // 
            lblFirmar.AutoSize = true;
            lblFirmar.Location = new Point(78, 44);
            lblFirmar.Margin = new Padding(4, 0, 4, 0);
            lblFirmar.Name = "lblFirmar";
            lblFirmar.Size = new Size(44, 15);
            lblFirmar.TabIndex = 1;
            lblFirmar.Text = "Firmar:";
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(534, 254);
            BtnLimpiar.Margin = new Padding(4, 3, 4, 3);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(88, 27);
            BtnLimpiar.TabIndex = 2;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(78, 102);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 359);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown_1;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            pictureBox1.MouseUp += pictureBox1_MouseUp_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(534, 204);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 30);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnGuardar);
            Controls.Add(BtnLimpiar);
            Controls.Add(lblFirmar);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblFirmar;
        private Button BtnLimpiar;
        private Button btnGuardar;
    }
}

