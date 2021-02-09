namespace PRII_U108_VisualStudio
{
    partial class Form1
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
            this.lblMate = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.lblRedes = new System.Windows.Forms.Label();
            this.lblSw = new System.Windows.Forms.Label();
            this.lblBd = new System.Windows.Forms.Label();
            this.btnCapturarCali = new System.Windows.Forms.Button();
            this.btnMaximaCal = new System.Windows.Forms.Button();
            this.btnMinimaCal = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.nudMate = new System.Windows.Forms.NumericUpDown();
            this.nudProg = new System.Windows.Forms.NumericUpDown();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudBD = new System.Windows.Forms.NumericUpDown();
            this.nudSW = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMate
            // 
            this.lblMate.AutoSize = true;
            this.lblMate.Location = new System.Drawing.Point(13, 26);
            this.lblMate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMate.Name = "lblMate";
            this.lblMate.Size = new System.Drawing.Size(152, 17);
            this.lblMate.TabIndex = 1;
            this.lblMate.Text = "Ingienieria en Software";
            this.lblMate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Location = new System.Drawing.Point(13, 59);
            this.lblProg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(106, 17);
            this.lblProg.TabIndex = 2;
            this.lblProg.Text = "Programacion II";
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Location = new System.Drawing.Point(13, 88);
            this.lblRedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(187, 17);
            this.lblRedes.TabIndex = 3;
            this.lblRedes.Text = "Administracion de Proyectos";
            // 
            // lblSw
            // 
            this.lblSw.AutoSize = true;
            this.lblSw.Location = new System.Drawing.Point(13, 122);
            this.lblSw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSw.Name = "lblSw";
            this.lblSw.Size = new System.Drawing.Size(199, 17);
            this.lblSw.TabIndex = 4;
            this.lblSw.Text = "Arquitectura de computadoras";
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.Location = new System.Drawing.Point(13, 158);
            this.lblBd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(109, 17);
            this.lblBd.TabIndex = 5;
            this.lblBd.Text = "Emprendedores";
            // 
            // btnCapturarCali
            // 
            this.btnCapturarCali.Location = new System.Drawing.Point(16, 190);
            this.btnCapturarCali.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturarCali.Name = "btnCapturarCali";
            this.btnCapturarCali.Size = new System.Drawing.Size(370, 34);
            this.btnCapturarCali.TabIndex = 10;
            this.btnCapturarCali.Text = "Capturar";
            this.btnCapturarCali.UseVisualStyleBackColor = true;
            this.btnCapturarCali.Click += new System.EventHandler(this.btnCapturarCali_Click);
            // 
            // btnMaximaCal
            // 
            this.btnMaximaCal.Location = new System.Drawing.Point(414, 20);
            this.btnMaximaCal.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximaCal.Name = "btnMaximaCal";
            this.btnMaximaCal.Size = new System.Drawing.Size(199, 28);
            this.btnMaximaCal.TabIndex = 13;
            this.btnMaximaCal.Text = "Calificacion Max";
            this.btnMaximaCal.UseVisualStyleBackColor = true;
            this.btnMaximaCal.Click += new System.EventHandler(this.btnMaximaCal_Click);
            // 
            // btnMinimaCal
            // 
            this.btnMinimaCal.Location = new System.Drawing.Point(414, 59);
            this.btnMinimaCal.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimaCal.Name = "btnMinimaCal";
            this.btnMinimaCal.Size = new System.Drawing.Size(199, 28);
            this.btnMinimaCal.TabIndex = 14;
            this.btnMinimaCal.Text = "Mínima Calificacion";
            this.btnMinimaCal.UseVisualStyleBackColor = true;
            this.btnMinimaCal.Click += new System.EventHandler(this.btnMinimaCal_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(414, 95);
            this.btnPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(199, 28);
            this.btnPromedio.TabIndex = 15;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(414, 131);
            this.rtbDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(197, 93);
            this.rtbDescripcion.TabIndex = 17;
            this.rtbDescripcion.Text = "";
            // 
            // nudMate
            // 
            this.nudMate.Location = new System.Drawing.Point(226, 21);
            this.nudMate.Margin = new System.Windows.Forms.Padding(4);
            this.nudMate.Name = "nudMate";
            this.nudMate.Size = new System.Drawing.Size(160, 22);
            this.nudMate.TabIndex = 18;
            this.nudMate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMate.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudProg
            // 
            this.nudProg.Location = new System.Drawing.Point(226, 54);
            this.nudProg.Margin = new System.Windows.Forms.Padding(4);
            this.nudProg.Name = "nudProg";
            this.nudProg.Size = new System.Drawing.Size(160, 22);
            this.nudProg.TabIndex = 19;
            this.nudProg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(226, 83);
            this.nudRed.Margin = new System.Windows.Forms.Padding(4);
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(160, 22);
            this.nudRed.TabIndex = 20;
            this.nudRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudBD
            // 
            this.nudBD.Location = new System.Drawing.Point(226, 153);
            this.nudBD.Margin = new System.Windows.Forms.Padding(4);
            this.nudBD.Name = "nudBD";
            this.nudBD.Size = new System.Drawing.Size(160, 22);
            this.nudBD.TabIndex = 21;
            this.nudBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudSW
            // 
            this.nudSW.Location = new System.Drawing.Point(226, 120);
            this.nudSW.Margin = new System.Windows.Forms.Padding(4);
            this.nudSW.Name = "nudSW";
            this.nudSW.Size = new System.Drawing.Size(160, 22);
            this.nudSW.TabIndex = 22;
            this.nudSW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 241);
            this.Controls.Add(this.nudSW);
            this.Controls.Add(this.nudBD);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.nudProg);
            this.Controls.Add(this.nudMate);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnMinimaCal);
            this.Controls.Add(this.btnMaximaCal);
            this.Controls.Add(this.btnCapturarCali);
            this.Controls.Add(this.lblBd);
            this.Controls.Add(this.lblSw);
            this.Controls.Add(this.lblRedes);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblMate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMate;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.Label lblSw;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.Button btnCapturarCali;
        private System.Windows.Forms.Button btnMaximaCal;
        private System.Windows.Forms.Button btnMinimaCal;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.NumericUpDown nudMate;
        private System.Windows.Forms.NumericUpDown nudProg;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudBD;
        private System.Windows.Forms.NumericUpDown nudSW;
    }
}

