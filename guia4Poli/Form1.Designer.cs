namespace guia4Poli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inpMaq = new System.Windows.Forms.NumericUpDown();
            this.inpHum = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGraf = new System.Windows.Forms.Panel();
            this.btnTablero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpMaq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpHum)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inpMaq);
            this.panel1.Controls.Add(this.inpHum);
            this.panel1.Location = new System.Drawing.Point(12, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 107);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jugadores (max 4)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maquina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Humanos";
            // 
            // inpMaq
            // 
            this.inpMaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMaq.Location = new System.Drawing.Point(143, 54);
            this.inpMaq.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.inpMaq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpMaq.Name = "inpMaq";
            this.inpMaq.Size = new System.Drawing.Size(86, 34);
            this.inpMaq.TabIndex = 9;
            this.inpMaq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpMaq.ValueChanged += new System.EventHandler(this.inpMaq_ValueChanged);
            this.inpMaq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // inpHum
            // 
            this.inpHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpHum.Location = new System.Drawing.Point(14, 54);
            this.inpHum.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.inpHum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpHum.Name = "inpHum";
            this.inpHum.Size = new System.Drawing.Size(86, 34);
            this.inpHum.TabIndex = 7;
            this.inpHum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpHum.ValueChanged += new System.EventHandler(this.inpMaq_ValueChanged);
            this.inpHum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(12, 336);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(274, 56);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear Juego";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cbNivel
            // 
            this.cbNivel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(5, 37);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(266, 24);
            this.cbNivel.TabIndex = 16;
            this.cbNivel.SelectedValueChanged += new System.EventHandler(this.cbNivel_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbNivel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 68);
            this.panel2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nivel de Juego";
            // 
            // panelGraf
            // 
            this.panelGraf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraf.BackgroundImage = global::guia4Poli.Properties.Resources.background;
            this.panelGraf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelGraf.Location = new System.Drawing.Point(76, 86);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(136, 129);
            this.panelGraf.TabIndex = 18;
            // 
            // btnTablero
            // 
            this.btnTablero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTablero.AutoEllipsis = true;
            this.btnTablero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTablero.BackColor = System.Drawing.Color.IndianRed;
            this.btnTablero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablero.ForeColor = System.Drawing.Color.Transparent;
            this.btnTablero.Location = new System.Drawing.Point(218, 128);
            this.btnTablero.MinimumSize = new System.Drawing.Size(50, 20);
            this.btnTablero.Name = "btnTablero";
            this.btnTablero.Size = new System.Drawing.Size(70, 58);
            this.btnTablero.TabIndex = 19;
            this.btnTablero.Text = "Otro";
            this.btnTablero.UseVisualStyleBackColor = false;
            this.btnTablero.Visible = false;
            this.btnTablero.Click += new System.EventHandler(this.btnTablero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 404);
            this.Controls.Add(this.btnTablero);
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpMaq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpHum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inpMaq;
        private System.Windows.Forms.NumericUpDown inpHum;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelGraf;
        private System.Windows.Forms.Button btnTablero;
    }
}

