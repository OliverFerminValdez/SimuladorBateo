namespace SimuladorBateo
{
    partial class SeguimientoJugadores
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
            this.components = new System.ComponentModel.Container();
            this.SeguimientoDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SeguimientoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SeguimientoDGV
            // 
            this.SeguimientoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeguimientoDGV.Location = new System.Drawing.Point(13, 59);
            this.SeguimientoDGV.Name = "SeguimientoDGV";
            this.SeguimientoDGV.RowHeadersWidth = 51;
            this.SeguimientoDGV.RowTemplate.Height = 24;
            this.SeguimientoDGV.Size = new System.Drawing.Size(1209, 424);
            this.SeguimientoDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seguimiento de jugadores";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SeguimientoJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeguimientoDGV);
            this.Name = "SeguimientoJugadores";
            this.Text = "SeguimientoJugadores";
            this.Load += new System.EventHandler(this.SeguimientoJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeguimientoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SeguimientoDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}