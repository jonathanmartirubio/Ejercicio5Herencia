using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio5
{
    public partial class fCurso : Form
    {
        public fCurso()
        {
            InitializeComponent();
        }

        public tListadeCursos Cursos;
        public tListaPersonas Personas;

        private void bAnyadirCurso_Click(object sender, EventArgs e)
        {
            string nombre;
            int codigo;

            nombre = Interaction.InputBox("Introduce el nombre del curso:", "Añadir Curso");
            codigo = int.Parse(Interaction.InputBox("Introduce el código del curso:", "Añadir Curso"));

            Cursos.AnyadirCurso(nombre, codigo);
        }

        private void bEliminarCurso_Click(object sender, EventArgs e)
        {
            int codigo;
            bool correcto;

            codigo = int.Parse(Interaction.InputBox("Introduce el código del curso", "Eliminar Curso"));
            correcto = Cursos.EliminarCurso(codigo);

            if (correcto)
            {
                MessageBox.Show("Curso eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Curso.");
            }
        }

        private void bMostrarCursos_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Cursos.MostrarCursos();

            MessageBox.Show(texto);
        }

        private void bMostrarAlumnosCurso_Click(object sender, EventArgs e)
        {
            string texto;
            bool existecurso;
            int codigo;
            codigo = int.Parse(Interaction.InputBox("Introduce el código del curso:", "Mostrar Alumnos por Curso"));
            existecurso = Cursos.ExisteCurso(codigo);

            if (existecurso)
            {
                texto = Alumnos.MostrarAlumnosPorCurso(codigo);
                MessageBox.Show(texto);
            }
            else
            {
                texto = "No existe el curso introducido.";
                MessageBox.Show(texto);
            }

        }
    }
}
