
namespace Ejercicio5
{
    partial class fCurso
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
            this.bAnyadirCurso = new System.Windows.Forms.Button();
            this.bEliminarCurso = new System.Windows.Forms.Button();
            this.bMostrarCursos = new System.Windows.Forms.Button();
            this.bMostrarAlumnosCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAnyadirCurso
            // 
            this.bAnyadirCurso.Location = new System.Drawing.Point(84, 51);
            this.bAnyadirCurso.Name = "bAnyadirCurso";
            this.bAnyadirCurso.Size = new System.Drawing.Size(219, 74);
            this.bAnyadirCurso.TabIndex = 0;
            this.bAnyadirCurso.Text = "Añadir Curso";
            this.bAnyadirCurso.UseVisualStyleBackColor = true;
            this.bAnyadirCurso.Click += new System.EventHandler(this.bAnyadirCurso_Click);
            // 
            // bEliminarCurso
            // 
            this.bEliminarCurso.Location = new System.Drawing.Point(84, 140);
            this.bEliminarCurso.Name = "bEliminarCurso";
            this.bEliminarCurso.Size = new System.Drawing.Size(219, 74);
            this.bEliminarCurso.TabIndex = 1;
            this.bEliminarCurso.Text = "Eliminar Curso";
            this.bEliminarCurso.UseVisualStyleBackColor = true;
            this.bEliminarCurso.Click += new System.EventHandler(this.bEliminarCurso_Click);
            // 
            // bMostrarCursos
            // 
            this.bMostrarCursos.Location = new System.Drawing.Point(84, 229);
            this.bMostrarCursos.Name = "bMostrarCursos";
            this.bMostrarCursos.Size = new System.Drawing.Size(219, 74);
            this.bMostrarCursos.TabIndex = 2;
            this.bMostrarCursos.Text = "Mostrar todos los Cursos";
            this.bMostrarCursos.UseVisualStyleBackColor = true;
            this.bMostrarCursos.Click += new System.EventHandler(this.bMostrarCursos_Click);
            // 
            // bMostrarAlumnosCurso
            // 
            this.bMostrarAlumnosCurso.Location = new System.Drawing.Point(84, 321);
            this.bMostrarAlumnosCurso.Name = "bMostrarAlumnosCurso";
            this.bMostrarAlumnosCurso.Size = new System.Drawing.Size(219, 74);
            this.bMostrarAlumnosCurso.TabIndex = 3;
            this.bMostrarAlumnosCurso.Text = "Mostrar todos los Alumnos pertenecientes a un Curso";
            this.bMostrarAlumnosCurso.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosCurso.Click += new System.EventHandler(this.bMostrarAlumnosCurso_Click);
            // 
            // fCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.bMostrarAlumnosCurso);
            this.Controls.Add(this.bMostrarCursos);
            this.Controls.Add(this.bEliminarCurso);
            this.Controls.Add(this.bAnyadirCurso);
            this.Name = "fCurso";
            this.Text = "Ejercicio 5 - Gestión de Cursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAnyadirCurso;
        private System.Windows.Forms.Button bEliminarCurso;
        private System.Windows.Forms.Button bMostrarCursos;
        private System.Windows.Forms.Button bMostrarAlumnosCurso;
    }
}