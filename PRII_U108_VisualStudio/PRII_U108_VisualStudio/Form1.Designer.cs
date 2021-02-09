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
            this.tbCalcular = new System.Windows.Forms.TextBox();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.btnAñadirEstudiantes = new System.Windows.Forms.Button();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.tbMaterias = new System.Windows.Forms.TextBox();
            this.btnAñadirMaterias = new System.Windows.Forms.Button();
            this.tbEstudiante = new System.Windows.Forms.TextBox();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.tbCalificaciones = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCalcular
            // 
            this.tbCalcular.Location = new System.Drawing.Point(219, 43);
            this.tbCalcular.Multiline = true;
            this.tbCalcular.Name = "tbCalcular";
            this.tbCalcular.Size = new System.Drawing.Size(209, 243);
            this.tbCalcular.TabIndex = 11;
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(15, 43);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(159, 24);
            this.cbEstudiante.TabIndex = 12;
            this.cbEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbEstudiante_SelectedIndexChanged);
            // 
            // btnAñadirEstudiantes
            // 
            this.btnAñadirEstudiantes.Location = new System.Drawing.Point(15, 118);
            this.btnAñadirEstudiantes.Name = "btnAñadirEstudiantes";
            this.btnAñadirEstudiantes.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirEstudiantes.TabIndex = 13;
            this.btnAñadirEstudiantes.Text = "Añadir";
            this.btnAñadirEstudiantes.UseVisualStyleBackColor = true;
            this.btnAñadirEstudiantes.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(12, 15);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(82, 17);
            this.lblEstudiante.TabIndex = 14;
            this.lblEstudiante.Text = "Estudiantes";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(12, 153);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 17);
            this.lblMateria.TabIndex = 15;
            this.lblMateria.Text = "Materia";
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(15, 183);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(159, 24);
            this.cbMaterias.TabIndex = 16;
            // 
            // tbMaterias
            // 
            this.tbMaterias.Location = new System.Drawing.Point(15, 223);
            this.tbMaterias.Name = "tbMaterias";
            this.tbMaterias.Size = new System.Drawing.Size(159, 22);
            this.tbMaterias.TabIndex = 17;
            // 
            // btnAñadirMaterias
            // 
            this.btnAñadirMaterias.Location = new System.Drawing.Point(18, 302);
            this.btnAñadirMaterias.Name = "btnAñadirMaterias";
            this.btnAñadirMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirMaterias.TabIndex = 19;
            this.btnAñadirMaterias.Text = "Añadir";
            this.btnAñadirMaterias.UseVisualStyleBackColor = true;
            this.btnAñadirMaterias.Click += new System.EventHandler(this.btnAñadirMaterias_Click);
            // 
            // tbEstudiante
            // 
            this.tbEstudiante.Location = new System.Drawing.Point(15, 81);
            this.tbEstudiante.Name = "tbEstudiante";
            this.tbEstudiante.Size = new System.Drawing.Size(159, 22);
            this.tbEstudiante.TabIndex = 20;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(99, 118);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEstudiante.TabIndex = 21;
            this.btnEliminarEstudiante.Text = "Eliminar";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(99, 302);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMateria.TabIndex = 22;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // tbCalificaciones
            // 
            this.tbCalificaciones.Location = new System.Drawing.Point(15, 264);
            this.tbCalificaciones.Name = "tbCalificaciones";
            this.tbCalificaciones.Size = new System.Drawing.Size(159, 22);
            this.tbCalificaciones.TabIndex = 23;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(180, 302);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 24;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 337);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.tbCalificaciones);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.tbEstudiante);
            this.Controls.Add(this.btnAñadirMaterias);
            this.Controls.Add(this.tbMaterias);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.btnAñadirEstudiantes);
            this.Controls.Add(this.cbEstudiante);
            this.Controls.Add(this.tbCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCalcular;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.Button btnAñadirEstudiantes;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.TextBox tbMaterias;
        private System.Windows.Forms.Button btnAñadirMaterias;
        private System.Windows.Forms.TextBox tbEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.TextBox tbCalificaciones;
        private System.Windows.Forms.Button btnCapturar;
    }
}

