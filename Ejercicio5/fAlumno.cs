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
    public partial class fAlumno : Form
    {
        public fAlumno(tListaPersonas Instituto, tListadeCursos Cursos)
        {
            InitializeComponent();

            this.Instituto = Instituto;
            this.Cursos = Cursos;
        }

        private tListaPersonas Instituto;
        private tListadeCursos Cursos;

        private void bAnyadirAlumno_Click(object sender, EventArgs e)
        {
            string nombre, dni, telf;
            int codigo;
            bool existecurso;

            nombre = Interaction.InputBox("Introduce el nombre:", "Añadir Alumno");
            dni = Interaction.InputBox("Introduce el DNI:", "Añadir Alumno");
            telf = Interaction.InputBox("Introduce el teléfono:", "Añadir Alumno");
            codigo = int.Parse(Interaction.InputBox("Introduce el código del curso:", "Añadir Alumno"));
            existecurso = Cursos.ExisteCurso(codigo);
            if (!existecurso)
            {
                MessageBox.Show("El curso introducido no existe. Introduzca uno válido o cree uno nuevo.");
            }
            else
            {
                Instituto.AnyadirAlumno(dni, nombre, telf, codigo);
            }
        }

        private void bEliminarAlumno_Click(object sender, EventArgs e)
        {
            string nombre;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre", "Eliminar Alumno");
            correcto = Instituto.Eliminar(nombre);

            if (correcto)
            {
                MessageBox.Show("Alumno eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el alumno.");
            }
        }

        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Instituto.MostrarAlumnos();

            MessageBox.Show(texto);
        }

        private void bOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            Instituto.OrdenarAlumnos();
            MessageBox.Show("Lista de Alumnos ordenada alfabéticamente.");
        }

        private void bMostrarAlumno_Click(object sender, EventArgs e)
        {
            string texto, nombre;
            bool correcto;
            correcto = false;
            nombre = Interaction.InputBox("Nombre del Alumno:", "Mostrar datos del alumno");
            texto = Instituto.MostrarAlumno(nombre, ref correcto);

            if (correcto)
            {
                MessageBox.Show(texto);
            }
            else
            {
                texto = "No se ha encontrado el Alumno.";
                MessageBox.Show(texto);
            }
        }

        private void bMostrarPorCurso_Click(object sender, EventArgs e)
        {
            string texto;
            bool existecurso;
            int codigo;
            codigo = int.Parse(Interaction.InputBox("Introduce el código del curso:", "Mostrar Alumnos por Curso"));
            existecurso = Cursos.ExisteCurso(codigo);

            if (existecurso)
            {
                texto = Instituto.MostrarAlumnosPorCurso(codigo);
                MessageBox.Show(texto);
            }
            else
            {
                texto = "No existe el curso introducido.";
                MessageBox.Show(texto);
            }
        }

        private void bAnyadirNota_Click(object sender, EventArgs e)
        {
            string nombre;
            double nota;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            nota = double.Parse(Interaction.InputBox("Introduzca la Nota."));

            correcto = Instituto.AnyadirNota(nombre, nota);
            if (correcto)
                MessageBox.Show("Se ha añadido correctamente la nota.");
            else
                MessageBox.Show("No se ha encontrado el Alumno.");
        }

        private void bEliminarNotas_Click(object sender, EventArgs e)
        {
            string nombre;
            bool correcto, tienenotas, existe;

            nombre = Interaction.InputBox("Introduce el nombre", "Eliminar Notas");
            existe = Instituto.ExisteAlumno(nombre);

            if (existe)
            {
                tienenotas = Instituto.TieneNotas(nombre);

                if (tienenotas)
                {
                    correcto = Instituto.EliminarNotas(nombre);
                    if (correcto)
                    {
                        MessageBox.Show("Notas eliminadas correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado el Alumno.");
                    }
                }
                else
                {
                    MessageBox.Show("El alumno no tiene notas.");
                }
            }
            else
            {
                MessageBox.Show("No existe el alumno introducido.");
            }
        }

        private void bAlumnosMediaAprobado_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Instituto.MostrarAlumnosMediaAprobado();

            MessageBox.Show(texto);
        }

        private void bMostrarAlumnosSuspensos_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Instituto.MostrarAlumnosMediaSuspenso();

            MessageBox.Show(texto);
        }
    }
}
