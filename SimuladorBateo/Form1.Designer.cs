namespace SimuladorBateo
{
    partial class Simulador
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
            this.components = new System.ComponentModel.Container();
            this.JugadorLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DiaNUD = new System.Windows.Forms.NumericUpDown();
            this.Dia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HRNUD = new System.Windows.Forms.NumericUpDown();
            this.FoulsNUD = new System.Windows.Forms.NumericUpDown();
            this.HitsNUD = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DespuesPB = new System.Windows.Forms.PictureBox();
            this.PelotaPB = new System.Windows.Forms.PictureBox();
            this.AntesPB = new System.Windows.Forms.PictureBox();
            this.MaquinaPB = new System.Windows.Forms.PictureBox();
            this.AccionPanel = new System.Windows.Forms.Panel();
            this.PromedioNUD = new System.Windows.Forms.NumericUpDown();
            this.LanzamientosTotalesNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.LanzamientoTb = new System.Windows.Forms.TextBox();
            this.BateoTb = new System.Windows.Forms.TextBox();
            this.DiagnosticoPanel = new System.Windows.Forms.Panel();
            this.CondicionRTB = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Movimiento = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiaNUD)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoulsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitsNUD)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DespuesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PelotaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaPB)).BeginInit();
            this.AccionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromedioNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanzamientosTotalesNUD)).BeginInit();
            this.DiagnosticoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JugadorLb
            // 
            this.JugadorLb.AutoSize = true;
            this.JugadorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadorLb.Location = new System.Drawing.Point(387, 23);
            this.JugadorLb.Name = "JugadorLb";
            this.JugadorLb.Size = new System.Drawing.Size(94, 24);
            this.JugadorLb.TabIndex = 0;
            this.JugadorLb.Text = "Jugador x";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DiaNUD);
            this.panel1.Controls.Add(this.Dia);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(701, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 51);
            this.panel1.TabIndex = 2;
            // 
            // DiaNUD
            // 
            this.DiaNUD.Location = new System.Drawing.Point(150, 4);
            this.DiaNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DiaNUD.Name = "DiaNUD";
            this.DiaNUD.Size = new System.Drawing.Size(86, 28);
            this.DiaNUD.TabIndex = 17;
            // 
            // Dia
            // 
            this.Dia.AutoSize = true;
            this.Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.Location = new System.Drawing.Point(95, 6);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(37, 24);
            this.Dia.TabIndex = 11;
            this.Dia.Text = "Dia";
            this.Dia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.HRNUD);
            this.panel2.Controls.Add(this.FoulsNUD);
            this.panel2.Controls.Add(this.HitsNUD);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(868, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 129);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Home runs";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fouls";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hits";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HRNUD
            // 
            this.HRNUD.Location = new System.Drawing.Point(130, 80);
            this.HRNUD.Name = "HRNUD";
            this.HRNUD.Size = new System.Drawing.Size(124, 28);
            this.HRNUD.TabIndex = 17;
            // 
            // FoulsNUD
            // 
            this.FoulsNUD.Location = new System.Drawing.Point(130, 46);
            this.FoulsNUD.Name = "FoulsNUD";
            this.FoulsNUD.Size = new System.Drawing.Size(124, 28);
            this.FoulsNUD.TabIndex = 16;
            // 
            // HitsNUD
            // 
            this.HitsNUD.Location = new System.Drawing.Point(130, 12);
            this.HitsNUD.Name = "HitsNUD";
            this.HitsNUD.Size = new System.Drawing.Size(124, 28);
            this.HitsNUD.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.DespuesPB);
            this.panel3.Controls.Add(this.PelotaPB);
            this.panel3.Controls.Add(this.AntesPB);
            this.panel3.Controls.Add(this.MaquinaPB);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(25, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 206);
            this.panel3.TabIndex = 4;
            // 
            // DespuesPB
            // 
            this.DespuesPB.Image = global::SimuladorBateo.Properties.Resources.despues_de_swing;
            this.DespuesPB.Location = new System.Drawing.Point(24, 36);
            this.DespuesPB.Name = "DespuesPB";
            this.DespuesPB.Size = new System.Drawing.Size(168, 152);
            this.DespuesPB.TabIndex = 3;
            this.DespuesPB.TabStop = false;
            // 
            // PelotaPB
            // 
            this.PelotaPB.Image = global::SimuladorBateo.Properties.Resources.bola;
            this.PelotaPB.Location = new System.Drawing.Point(773, 92);
            this.PelotaPB.Name = "PelotaPB";
            this.PelotaPB.Size = new System.Drawing.Size(49, 38);
            this.PelotaPB.TabIndex = 2;
            this.PelotaPB.TabStop = false;
            // 
            // AntesPB
            // 
            this.AntesPB.Image = global::SimuladorBateo.Properties.Resources.Antes_de_swing;
            this.AntesPB.Location = new System.Drawing.Point(28, 37);
            this.AntesPB.Name = "AntesPB";
            this.AntesPB.Size = new System.Drawing.Size(164, 151);
            this.AntesPB.TabIndex = 1;
            this.AntesPB.TabStop = false;
            // 
            // MaquinaPB
            // 
            this.MaquinaPB.Image = global::SimuladorBateo.Properties.Resources.Maquina_de_picheo_vacana;
            this.MaquinaPB.Location = new System.Drawing.Point(840, 38);
            this.MaquinaPB.Name = "MaquinaPB";
            this.MaquinaPB.Size = new System.Drawing.Size(140, 151);
            this.MaquinaPB.TabIndex = 0;
            this.MaquinaPB.TabStop = false;
            // 
            // AccionPanel
            // 
            this.AccionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccionPanel.Controls.Add(this.PromedioNUD);
            this.AccionPanel.Controls.Add(this.LanzamientosTotalesNUD);
            this.AccionPanel.Controls.Add(this.label3);
            this.AccionPanel.Controls.Add(this.label2);
            this.AccionPanel.Controls.Add(this.label1);
            this.AccionPanel.Controls.Add(this.Label);
            this.AccionPanel.Controls.Add(this.LanzamientoTb);
            this.AccionPanel.Controls.Add(this.BateoTb);
            this.AccionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccionPanel.Location = new System.Drawing.Point(12, 389);
            this.AccionPanel.Name = "AccionPanel";
            this.AccionPanel.Size = new System.Drawing.Size(685, 129);
            this.AccionPanel.TabIndex = 5;
            // 
            // PromedioNUD
            // 
            this.PromedioNUD.Location = new System.Drawing.Point(180, 82);
            this.PromedioNUD.Name = "PromedioNUD";
            this.PromedioNUD.Size = new System.Drawing.Size(168, 28);
            this.PromedioNUD.TabIndex = 16;
            // 
            // LanzamientosTotalesNUD
            // 
            this.LanzamientosTotalesNUD.Location = new System.Drawing.Point(542, 47);
            this.LanzamientosTotalesNUD.Name = "LanzamientosTotalesNUD";
            this.LanzamientosTotalesNUD.Size = new System.Drawing.Size(124, 28);
            this.LanzamientosTotalesNUD.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "No. Lanzamientos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Promedio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bateo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(34, 16);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(117, 24);
            this.Label.TabIndex = 9;
            this.Label.Text = "Lanzamiento";
            this.Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LanzamientoTb
            // 
            this.LanzamientoTb.Location = new System.Drawing.Point(180, 12);
            this.LanzamientoTb.Name = "LanzamientoTb";
            this.LanzamientoTb.Size = new System.Drawing.Size(168, 28);
            this.LanzamientoTb.TabIndex = 7;
            // 
            // BateoTb
            // 
            this.BateoTb.Location = new System.Drawing.Point(180, 47);
            this.BateoTb.Name = "BateoTb";
            this.BateoTb.Size = new System.Drawing.Size(168, 28);
            this.BateoTb.TabIndex = 6;
            // 
            // DiagnosticoPanel
            // 
            this.DiagnosticoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiagnosticoPanel.Controls.Add(this.CondicionRTB);
            this.DiagnosticoPanel.Controls.Add(this.label7);
            this.DiagnosticoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosticoPanel.Location = new System.Drawing.Point(1040, 127);
            this.DiagnosticoPanel.Name = "DiagnosticoPanel";
            this.DiagnosticoPanel.Size = new System.Drawing.Size(207, 206);
            this.DiagnosticoPanel.TabIndex = 6;
            // 
            // CondicionRTB
            // 
            this.CondicionRTB.Location = new System.Drawing.Point(3, 48);
            this.CondicionRTB.Name = "CondicionRTB";
            this.CondicionRTB.Size = new System.Drawing.Size(199, 132);
            this.CondicionRTB.TabIndex = 11;
            this.CondicionRTB.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Condicion Fisica";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(106, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Movimiento
            // 
            this.Movimiento.Interval = 1;
            this.Movimiento.Tick += new System.EventHandler(this.Movimiento_Tick);
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DiagnosticoPanel);
            this.Controls.Add(this.AccionPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JugadorLb);
            this.Name = "Simulador";
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Simulador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiaNUD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoulsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitsNUD)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DespuesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PelotaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaPB)).EndInit();
            this.AccionPanel.ResumeLayout(false);
            this.AccionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromedioNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanzamientosTotalesNUD)).EndInit();
            this.DiagnosticoPanel.ResumeLayout(false);
            this.DiagnosticoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JugadorLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel AccionPanel;
        private System.Windows.Forms.TextBox LanzamientoTb;
        private System.Windows.Forms.TextBox BateoTb;
        private System.Windows.Forms.Panel DiagnosticoPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown HRNUD;
        private System.Windows.Forms.NumericUpDown FoulsNUD;
        private System.Windows.Forms.NumericUpDown HitsNUD;
        private System.Windows.Forms.NumericUpDown LanzamientosTotalesNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Dia;
        private System.Windows.Forms.PictureBox PelotaPB;
        private System.Windows.Forms.PictureBox AntesPB;
        private System.Windows.Forms.PictureBox MaquinaPB;
        private System.Windows.Forms.RichTextBox CondicionRTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown PromedioNUD;
        private System.Windows.Forms.NumericUpDown DiaNUD;
        private System.Windows.Forms.PictureBox DespuesPB;
        private System.Windows.Forms.Timer Movimiento;
    }
}

