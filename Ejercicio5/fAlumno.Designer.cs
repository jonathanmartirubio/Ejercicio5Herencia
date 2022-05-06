
namespace Ejercicio5
{
    partial class fAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAnyadirAlumno = new System.Windows.Forms.Button();
            this.bMostrarPorCurso = new System.Windows.Forms.Button();
            this.bMostrarAlumno = new System.Windows.Forms.Button();
            this.bMostrarAlumnos = new System.Windows.Forms.Button();
            this.bOrdenAlfabetico = new System.Windows.Forms.Button();
            this.bEliminarAlumno = new System.Windows.Forms.Button();
            this.bMostrarAlumnosSuspensos = new System.Windows.Forms.Button();
            this.bEliminarNotas = new System.Windows.Forms.Button();
            this.bAlumnosMediaAprobado = new System.Windows.Forms.Button();
            this.bAnyadirNota = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEliminarAlumno);
            this.groupBox1.Controls.Add(this.bOrdenAlfabetico);
            this.groupBox1.Controls.Add(this.bMostrarAlumnos);
            this.groupBox1.Controls.Add(this.bMostrarAlumno);
            this.groupBox1.Controls.Add(this.bMostrarPorCurso);
            this.groupBox1.Controls.Add(this.bAnyadirAlumno);
            this.groupBox1.Location = new System.Drawing.Point(44, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bMostrarAlumnosSuspensos);
            this.groupBox2.Controls.Add(this.bEliminarNotas);
            this.groupBox2.Controls.Add(this.bAlumnosMediaAprobado);
            this.groupBox2.Controls.Add(this.bAnyadirNota);
            this.groupBox2.Location = new System.Drawing.Point(44, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // bAnyadirAlumno
            // 
            this.bAnyadirAlumno.Location = new System.Drawing.Point(30, 26);
            this.bAnyadirAlumno.Name = "bAnyadirAlumno";
            this.bAnyadirAlumno.Size = new System.Drawing.Size(209, 60);
            this.bAnyadirAlumno.TabIndex = 0;
            this.bAnyadirAlumno.Text = "Añadir Alumno";
            this.bAnyadirAlumno.UseVisualStyleBackColor = true;
            this.bAnyadirAlumno.Click += new System.EventHandler(this.bAnyadirAlumno_Click);
            // 
            // bMostrarPorCurso
            // 
            this.bMostrarPorCurso.Location = new System.Drawing.Point(480, 99);
            this.bMostrarPorCurso.Name = "bMostrarPorCurso";
            this.bMostrarPorCurso.Size = new System.Drawing.Size(209, 60);
            this.bMostrarPorCurso.TabIndex = 1;
            this.bMostrarPorCurso.Text = "Mostrar Alumnos de un Curso";
            this.bMostrarPorCurso.UseVisualStyleBackColor = true;
            this.bMostrarPorCurso.Click += new System.EventHandler(this.bMostrarPorCurso_Click);
            // 
            // bMostrarAlumno
            // 
            this.bMostrarAlumno.Location = new System.Drawing.Point(254, 99);
            this.bMostrarAlumno.Name = "bMostrarAlumno";
            this.bMostrarAlumno.Size = new System.Drawing.Size(209, 60);
            this.bMostrarAlumno.TabIndex = 2;
            this.bMostrarAlumno.Text = "Mostrar Alumno (por nombre)";
            this.bMostrarAlumno.UseVisualStyleBackColor = true;
            this.bMostrarAlumno.Click += new System.EventHandler(this.bMostrarAlumno_Click);
            // 
            // bMostrarAlumnos
            // 
            this.bMostrarAlumnos.Location = new System.Drawing.Point(480, 26);
            this.bMostrarAlumnos.Name = "bMostrarAlumnos";
            this.bMostrarAlumnos.Size = new System.Drawing.Size(209, 60);
            this.bMostrarAlumnos.TabIndex = 3;
            this.bMostrarAlumnos.Text = "Mostrar Alumnos";
            this.bMostrarAlumnos.UseVisualStyleBackColor = true;
            this.bMostrarAlumnos.Click += new System.EventHandler(this.bMostrarAlumnos_Click);
            // 
            // bOrdenAlfabetico
            // 
            this.bOrdenAlfabetico.Location = new System.Drawing.Point(254, 26);
            this.bOrdenAlfabetico.Name = "bOrdenAlfabetico";
            this.bOrdenAlfabetico.Size = new System.Drawing.Size(209, 60);
            this.bOrdenAlfabetico.TabIndex = 4;
            this.bOrdenAlfabetico.Text = "Ordenar Alumnos por orden alfabético";
            this.bOrdenAlfabetico.UseVisualStyleBackColor = true;
            this.bOrdenAlfabetico.Click += new System.EventHandler(this.bOrdenAlfabetico_Click);
            // 
            // bEliminarAlumno
            // 
            this.bEliminarAlumno.Location = new System.Drawing.Point(30, 99);
            this.bEliminarAlumno.Name = "bEliminarAlumno";
            this.bEliminarAlumno.Size = new System.Drawing.Size(209, 60);
            this.bEliminarAlumno.TabIndex = 5;
            this.bEliminarAlumno.Text = "Eliminar Alumno";
            this.bEliminarAlumno.UseVisualStyleBackColor = true;
            this.bEliminarAlumno.Click += new System.EventHandler(this.bEliminarAlumno_Click);
            // 
            // bMostrarAlumnosSuspensos
            // 
            this.bMostrarAlumnosSuspensos.Location = new System.Drawing.Point(363, 106);
            this.bMostrarAlumnosSuspensos.Name = "bMostrarAlumnosSuspensos";
            this.bMostrarAlumnosSuspensos.Size = new System.Drawing.Size(326, 60);
            this.bMostrarAlumnosSuspensos.TabIndex = 6;
            this.bMostrarAlumnosSuspensos.Text = "Mostrar Alumnos con nota media menor a 5";
            this.bMostrarAlumnosSuspensos.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosSuspensos.Click += new System.EventHandler(this.bMostrarAlumnosSuspensos_Click);
            // 
            // bEliminarNotas
            // 
            this.bEliminarNotas.Location = new System.Drawing.Point(30, 106);
            this.bEliminarNotas.Name = "bEliminarNotas";
            this.bEliminarNotas.Size = new System.Drawing.Size(313, 60);
            this.bEliminarNotas.TabIndex = 7;
            this.bEliminarNotas.Text = "Eliminar Notas de un Alumno";
            this.bEliminarNotas.UseVisualStyleBackColor = true;
            this.bEliminarNotas.Click += new System.EventHandler(this.bEliminarNotas_Click);
            // 
            // bAlumnosMediaAprobado
            // 
            this.bAlumnosMediaAprobado.Location = new System.Drawing.Point(363, 26);
            this.bAlumnosMediaAprobado.Name = "bAlumnosMediaAprobado";
            this.bAlumnosMediaAprobado.Size = new System.Drawing.Size(326, 60);
            this.bAlumnosMediaAprobado.TabIndex = 8;
            this.bAlumnosMediaAprobado.Text = "Mostrar Alumnos con nota media mayor o igual a 5";
            this.bAlumnosMediaAprobado.UseVisualStyleBackColor = true;
            this.bAlumnosMediaAprobado.Click += new System.EventHandler(this.bAlumnosMediaAprobado_Click);
            // 
            // bAnyadirNota
            // 
            this.bAnyadirNota.Location = new System.Drawing.Point(30, 26);
            this.bAnyadirNota.Name = "bAnyadirNota";
            this.bAnyadirNota.Size = new System.Drawing.Size(313, 60);
            this.bAnyadirNota.TabIndex = 9;
            this.bAnyadirNota.Text = "Añadir Notas a Alumno";
            this.bAnyadirNota.UseVisualStyleBackColor = true;
            this.bAnyadirNota.Click += new System.EventHandler(this.bAnyadirNota_Click);
            // 
            // fAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAlumno";
            this.Text = "Ejercicio 5 - Gestión de Alumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEliminarAlumno;
        private System.Windows.Forms.Button bOrdenAlfabetico;
        private System.Windows.Forms.Button bMostrarAlumnos;
        private System.Windows.Forms.Button bMostrarAlumno;
        private System.Windows.Forms.Button bMostrarPorCurso;
        private System.Windows.Forms.Button bAnyadirAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarAlumnosSuspensos;
        private System.Windows.Forms.Button bEliminarNotas;
        private System.Windows.Forms.Button bAlumnosMediaAprobado;
        private System.Windows.Forms.Button bAnyadirNota;
    }
}