using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class tListaAlumnos
    {
        private List<tAlumno> mLista;

        public tListaAlumnos()
        {
            mLista = new List<tAlumno>();
        }
        /*
        public void AnyadirAlumno(string nombre, string dni, string telf, int codigo)
        {
            tAlumno alumno;

            alumno = new tAlumno();

            alumno.Nombre = nombre;
            alumno.Dni = dni;
            alumno.Telf = telf;
            alumno.CodigoCurso = codigo;

            mLista.Add(alumno);
        }

        public bool EliminarAlumno(string nombre)
        {
            int pos;
            bool encontrado = false;

            pos = BuscarAlumno(nombre);

            if (pos >= 0)
            {
                mLista.RemoveAt(pos);
                encontrado = true;
            }

            return encontrado;
        }

        private int BuscarAlumno(string nombre)
        {
            int pos = -1, i;
            bool encontrado = false;
            tAlumno alumno;

            i = 0;
            while (i < mLista.Count && !encontrado)
            {
                alumno = mLista[i];
                if (alumno.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
        */
        public string MostrarAlumnos()
        {
            string texto;

            texto = "Lista de Alumnos: \n";

            foreach (tAlumno alumno in mLista)
            {
                texto += alumno.MostrarDatos();
            }

            return texto;
        }

        public void OrdenAlfabetico()
        {
            int i, j;
            int tam, comparar;
            tam = mLista.Count;
            tAlumno aux;

            for (i = 0; i < tam - 1; i++)
                for (j = i + 1; j < tam; j++)
                {
                    comparar = string.Compare(mLista[i].Nombre, mLista[j].Nombre);
                    if (comparar > 0)
                    {
                        aux = mLista[i];
                        mLista[i] = mLista[j];
                        mLista[j] = aux;
                    }
                }

        }

        public string MostrarAlumnosPorCurso(int codigo)
        {
            string texto;
            bool hayalumnos;
            tAlumno alumno;

            texto = "";
            hayalumnos = AlumnosEnCurso(codigo);
            if (mLista.Count > 0)
            {
                for (int i = 0; i < mLista.Count; i++)
                {
                    alumno = mLista[i];
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

            for (int i = 0; i < mLista.Count; i++)
            {
                alumno = mLista[i];

                if (codigo == alumno.CodigoCurso)
                {
                    hayalumnos = true;
                }

            }

            return hayalumnos;
        }

        public string MostrarAlumno(string nombre, ref bool encontrado)
        {
            int pos;
            tAlumno alumno;
            string texto = "";

            pos = BuscarAlumno(nombre);

            if (pos >= 0)
            {
                alumno = mLista[pos];
                texto = alumno.MostrarDatos();
                encontrado = true;
            }

            return texto;
        }

        public bool ExisteAlumno(string nombre)
        {
            bool existe;
            int pos;

            existe = false;
            pos = BuscarAlumno(nombre);

            if (pos >= 0)
            {
                existe = true;
            }

            return existe;
        }

        public bool AnyadirNota(string nombre, double nota)
        {
            int pos;
            tAlumno alumno;
            bool encontrado = false;

            pos = BuscarAlumno(nombre);
            if (pos >= 0)
            {
                alumno = mLista[pos];
                alumno.AnyadirNota(nota);
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
            pos = BuscarAlumno(nombre);

            if (pos >= 0)
            {
                alumno = mLista[pos];
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

            pos = BuscarAlumno(nombre);
            alumno = mLista[pos];
            tienenotas = alumno.TieneNotas();

            return tienenotas;
        }

        public string MostrarAlumnosMediaAprobado()
        {
            tAlumno alumno;
            string texto;

            texto = "";

            for (int i = 0; i < mLista.Count; i++)
            {
                alumno = mLista[i];

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

            for (int i = 0; i < mLista.Count; i++)
            {
                alumno = mLista[i];

                if (alumno.NotaMedia() < 5)
                {
                    texto += alumno.MostrarDatos();
                }
            }

            return texto;
        }
    }
}
