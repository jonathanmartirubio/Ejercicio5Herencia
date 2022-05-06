using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class tListaProfesores : tListaPersonas
    {
        private List<tProfesor> mLista;

        public tListaProfesores()
        {
            mLista = new List<tProfesor>();
        }

        public void AnyadirProfesor(string nombre, string dni, string telf, bool tutor, int curso)
        {
            tProfesor profesor;
            profesor = new tProfesor();

            profesor.Nombre = nombre;
            profesor.Dni = dni;
            profesor.Telf = telf;
            profesor.Tutor = tutor;
            profesor.CodigoCurso = curso;

            mLista.Add(profesor);
        }

        public bool EliminarProfesor(string nombre)
        {
            int pos;
            bool encontrado = false;

            pos = BuscarProfesor(nombre);

            if (pos >= 0)
            {
                mLista.RemoveAt(pos);
                encontrado = true;
            }

            return encontrado;
        }

        private int BuscarProfesor(string nombre)
        {
            int pos = -1, i;
            bool encontrado = false;
            tProfesor profesor;

            i = 0;
            while (i < mLista.Count && !encontrado)
            {
                profesor = mLista[i];
                if (profesor.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
        public string MostrarProfesores()
        {
            string texto;

            texto = "Lista de Profesores: \n";

            foreach (tProfesor profesor in mLista)
            {
                texto += profesor.MostrarDatos();
            }

            return texto;
        }

        public string MostrarProfesor(string nombre, ref bool encontrado)
        {
            int pos;
            tProfesor profesor;
            string texto = "";

            pos = BuscarProfesor(nombre);

            if (pos >= 0)
            {
                profesor = mLista[pos];
                texto = profesor.MostrarDatos();
                encontrado = true;
            }

            return texto;
        }

        public void OrdenAlfabetico()
        {
            int i, j;
            int tam, comparar;
            tam = mLista.Count;
            tProfesor aux;

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

        public bool AnyadirAsignatura(string nombre, string asignatura)
        {
            int pos;
            tProfesor profesor;
            bool encontrado = false;

            pos = BuscarProfesor(nombre);
            if (pos >= 0)
            {
                profesor = mLista[pos];
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
            profesor = mLista[0];
            correcto = profesor.ImparteAsignatura(asignatura);

            for (int i = 0; i < mLista.Count; i++)
            {
                profesor = mLista[i];

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
            pos = BuscarProfesor(nombre);

            if (pos >= 0)
            {
                profesor = mLista[pos];
                profesor.EliminarAsignaturas();
                encontrado = true;
            }

            return encontrado;
        }
    }
}
