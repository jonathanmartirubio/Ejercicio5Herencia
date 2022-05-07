using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class tListaPersonas
    {
        private List<tPersona> mListaPersonas;
        private List<tPersona> mListaAlumnos;
        private List<tPersona> mListaProfesores;
        public tListaPersonas()
        {
            mListaPersonas = new List<tPersona>();
            mListaAlumnos = new List<tPersona>();
            mListaProfesores = new List<tPersona>();
        }
        public void AnyadirAlumno(string dni, string nombre, string tlf, int codCurso)
        {
            tAlumno alumno = new tAlumno(dni, nombre, tlf, codCurso);
            mListaPersonas.Add(alumno);
            mListaAlumnos.Add(alumno);
        }

        public void AnyadirProfesor(string dni, string nombre, string telf, string email, bool tutor, int codcurso)
        {
            tProfesor profesor = new tProfesor(dni, nombre, telf, email, tutor, codcurso);

            mListaPersonas.Add(profesor);
            mListaProfesores.Add(profesor);
        }

        public bool Eliminar(string nombre)
        {
            int pos;
            bool encontrado = false;
            tPersona persona;

            pos = Buscar(nombre);
            persona = mListaPersonas[pos];

            if (pos >= 0)
            {
                if (persona.GetType() == typeof(tProfesor))
                {
                    mListaProfesores.RemoveAt(pos);
                    encontrado = true;
                }
                if (persona.GetType() == typeof(tAlumno))
                {
                    mListaAlumnos.RemoveAt(pos);
                    encontrado = true;
                }
                mListaPersonas.RemoveAt(pos);
            }

            return encontrado;
        }

        private int Buscar(string nombre)
        {
            int pos = -1, i;
            bool encontrado = false;
            tPersona persona;

            i = 0;
            while (i < mListaPersonas.Count && !encontrado)
            {
                persona = mListaPersonas[i];
                if (persona.GetType() == typeof(tProfesor))
                {
                    persona = mListaProfesores[i];
                    if (persona.Nombre == nombre)
                    {
                        pos = i;
                        encontrado = true;
                    }
                }
                if (persona.GetType() == typeof(tAlumno))
                {
                    persona = mListaProfesores[i];
                    if (persona.Nombre == nombre)
                    {
                        pos = i;
                        encontrado = true;
                    }
                }

                i++;
            }

            return pos;
        }

        public string MostrarAlumnos()
        {
            string texto;

            texto = "Lista de Alumnos: \n";

            foreach (tAlumno alumno in mListaAlumnos)
            {
                texto += alumno.MostrarDatos();
            }

            return texto;
        }

        public string MostrarProfesores()
        {
            string texto;

            texto = "Lista de Profesores: \n";

            foreach (tProfesor profesor in mListaProfesores)
            {
                texto += profesor.MostrarDatos();
            }

            return texto;
        }

        public void OrdenarAlumnos()
        {
            int i, j;
            int tam, comparar;
            tam = mListaAlumnos.Count;
            tPersona aux;

            for (i = 0; i < tam - 1; i++)
                for (j = i + 1; j < tam; j++)
                {
                    comparar = string.Compare(mListaAlumnos[i].Nombre, mListaAlumnos[j].Nombre);
                    if (comparar > 0)
                    {
                        aux = mListaAlumnos[i];
                        mListaAlumnos[i] = mListaAlumnos[j];
                        mListaAlumnos[j] = aux;
                    }
                }

        }

        public void OrdenarProfesores()
        {
            int i, j;
            int tam, comparar;
            tam = mListaProfesores.Count;
            tPersona aux;

            for (i = 0; i < tam - 1; i++)
                for (j = i + 1; j < tam; j++)
                {
                    comparar = string.Compare(mListaProfesores[i].Nombre, mListaProfesores[j].Nombre);
                    if (comparar > 0)
                    {
                        aux = mListaProfesores[i];
                        mListaProfesores[i] = mListaProfesores[j];
                        mListaProfesores[j] = aux;
                    }
                }
        }

        public string MostrarAlumno(string nombre, ref bool encontrado)
        {
            int pos;
            tPersona alumno;
            string texto = "";

            pos = Buscar(nombre);

            if (pos >= 0)
            {
                alumno = mListaAlumnos[pos];
                texto = alumno.MostrarDatos();
                encontrado = true;
            }

            return texto;
        }

        public string MostrarProfesor(string nombre, ref bool encontrado)
        {
            int pos;
            tPersona profesor;
            string texto = "";

            pos = Buscar(nombre);

            if (pos >= 0)
            {
                profesor = mListaProfesores[pos];
                texto = profesor.MostrarDatos();
                encontrado = true;
            }

            return texto;
        }

        public bool AnyadirNota(string nombre, double nota)
        {
            int pos;
            tAlumno persona;
            bool encontrado = false;

            pos = Buscar(nombre);
            if (pos >= 0)
            {
                persona = (tAlumno)mListaAlumnos[pos];
                persona.AnyadirNota(nota);
                encontrado = true;
            }

            return encontrado;
        }

        public bool EliminarNotas(string nombre)
        {
            bool encontrado;
            int pos;
            tAlumno alumno;

            encontrado = false;
            pos = Buscar(nombre);

            if (pos >= 0)
            {
                alumno = (tAlumno)mListaAlumnos[pos];
                alumno.EliminarNotas();
                encontrado = true;
            }

            return encontrado;
        }

        public bool TieneNotas(string nombre)
        {
            bool tienenotas;
            tAlumno alumno;
            int pos;

            pos = Buscar(nombre);
            alumno = (tAlumno)mListaAlumnos[pos];
            tienenotas = alumno.TieneNotas();

            return tienenotas;
        }

        public bool ExisteAlumno(string nombre)
        {
            bool existe;
            int pos;

            existe = false;
            pos = Buscar(nombre);

            if (pos >= 0)
            {
                existe = true;
            }

            return existe;
        }

        public string MostrarAlumnosMediaAprobado()
        {
            tAlumno alumno;
            string texto;

            texto = "";

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alumno = (tAlumno)mListaAlumnos[i];

                if (alumno.NotaMedia() >= 5)
                {
                    texto += alumno.MostrarDatos();
                }
            }

            return texto;
        }

        public string MostrarAlumnosMediaSuspenso()
        {
            tAlumno alumno;
            string texto;

            texto = "";

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alumno = (tAlumno)mListaAlumnos[i];

                if (alumno.NotaMedia() < 5)
                {
                    texto += alumno.MostrarDatos();
                }
            }

            return texto;
        }

        public string MostrarAlumnosPorCurso(int codigo)
        {
            string texto;
            bool hayalumnos;
            tAlumno alumno;

            texto = "";
            hayalumnos = AlumnosEnCurso(codigo);
            if (mListaAlumnos.Count > 0)
            {
                for (int i = 0; i < mListaAlumnos.Count; i++)
                {
                    alumno = (tAlumno)mListaAlumnos[i];
                    if (hayalumnos)
                    {
                        texto += alumno.MostrarDatos();
                    }
                    else
                    {
                        texto += "El curso introducido no tiene alumnos matriculados.";
                    }
                }
            }
            else
            {
                texto += "No existen alumnos.";
            }


            return texto;
        }

        private bool AlumnosEnCurso(int codigo)
        {
            bool hayalumnos;
            tAlumno alumno;

            hayalumnos = false;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alumno = (tAlumno)mListaAlumnos[i];

                if (codigo == alumno.CodigoCurso)
                {
                    hayalumnos = true;
                }

            }

            return hayalumnos;
        }

        public bool AnyadirAsignatura(string nombre, string asignatura)
        {
            int pos;
            tProfesor profesor;
            bool encontrado = false;

            pos = Buscar(nombre);
            if (pos >= 0)
            {
                profesor = (tProfesor)mListaProfesores[pos];
                profesor.AnyadirAsignatura(asignatura);
                encontrado = true;
            }
            return encontrado;
        }

        public string MostrarProfesoresPorAsignatura(string asignatura)
        {
            string texto;
            bool correcto;
            tProfesor profesor;

            texto = "";
            profesor = (tProfesor)mListaProfesores[0];
            correcto = profesor.ImparteAsignatura(asignatura);

            for (int i = 0; i < mListaProfesores.Count; i++)
            {
                profesor = (tProfesor)mListaProfesores[i];

                if (correcto)
                {
                    texto += profesor.MostrarDatos();
                }
                else
                {
                    texto += "Ningún profesor imparte esa asignatura.";
                }
            }

            return texto;
        }

        public bool EliminarAsignaturas(string nombre)
        {
            bool encontrado;
            int pos;
            tProfesor profesor;

            encontrado = false;
            pos = Buscar(nombre);

            if (pos >= 0)
            {
                profesor = (tProfesor)mListaProfesores[pos];
                profesor.EliminarAsignaturas();
                encontrado = true;
            }

            return encontrado;
        }
    }
}
