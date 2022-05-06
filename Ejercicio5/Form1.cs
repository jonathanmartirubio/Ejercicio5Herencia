﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        tListaPersonas Personas = new tListaPersonas();
        tListadeCursos Cursos = new tListadeCursos();

        private void bGestionCursos_Click(object sender, EventArgs e)
        {
            fCurso fCur = new fCurso();

            fCur.Personas = Personas;
            fCur.Cursos = Cursos;

            fCur.ShowDialog();

        }

        private void bGestionAlumnos_Click(object sender, EventArgs e)
        {
            fAlumno fAlu = new fAlumno();

            fAlu.Personas = Personas;
            fAlu.Cursos = Cursos;

            fAlu.ShowDialog();
        }

        private void bGestionProfesores_Click(object sender, EventArgs e)
        {
            fProfesor fProf = new fProfesor();

            fProf.Personas = Personas;
            fProf.Cursos = Cursos;

            fProf.ShowDialog();
        }
    }
}
