
namespace Ejercicio5
{
    partial class Form1
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
            this.bGestionCursos = new System.Windows.Forms.Button();
            this.bGestionAlumnos = new System.Windows.Forms.Button();
            this.bGestionProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGestionCursos
            // 
            this.bGestionCursos.Location = new System.Drawing.Point(133, 72);
            this.bGestionCursos.Name = "bGestionCursos";
            this.bGestionCursos.Size = new System.Drawing.Size(236, 67);
            this.bGestionCursos.TabIndex = 0;
            this.bGestionCursos.Text = "Gestión de Cursos";
            this.bGestionCursos.UseVisualStyleBackColor = true;
            this.bGestionCursos.Click += new System.EventHandler(this.bGestionCursos_Click);
            // 
            // bGestionAlumnos
            // 
            this.bGestionAlumnos.Location = new System.Drawing.Point(133, 184);
            this.bGestionAlumnos.Name = "bGestionAlumnos";
            this.bGestionAlumnos.Size = new System.Drawing.Size(236, 67);
            this.bGestionAlumnos.TabIndex = 1;
            this.bGestionAlumnos.Text = "Gestión de Alumnos";
            this.bGestionAlumnos.UseVisualStyleBackColor = true;
            this.bGestionAlumnos.Click += new System.EventHandler(this.bGestionAlumnos_Click);
            // 
            // bGestionProfesores
            // 
            this.bGestionProfesores.Location = new System.Drawing.Point(133, 294);
            this.bGestionProfesores.Name = "bGestionProfesores";
            this.bGestionProfesores.Size = new System.Drawing.Size(236, 67);
            this.bGestionProfesores.TabIndex = 2;
            this.bGestionProfesores.Text = "Gestión de Profesores";
            this.bGestionProfesores.UseVisualStyleBackColor = true;
            this.bGestionProfesores.Click += new System.EventHandler(this.bGestionProfesores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.bGestionProfesores);
            this.Controls.Add(this.bGestionAlumnos);
            this.Controls.Add(this.bGestionCursos);
            this.Name = "Form1";
            this.Text = "Ejercicio 5 - Gestión de Instituto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGestionCursos;
        private System.Windows.Forms.Button bGestionAlumnos;
        private System.Windows.Forms.Button bGestionProfesores;
    }
}

