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
        public void AnyadirAlumno(string nombre, string dni, string tlf, int codCurso)
        {
            tAlumno alumno = new tAlumno(nombre, dni, tlf, codCurso);
            mListaPersonas.Add(alumno);
            mListaAlumnos.Add(alumno);
        }

        public void AnyadirProfesor(string nombre, string dni, string telf, string email, bool tutor, int codcurso)
        {
            tProfesor profesor = new tProfesor(nombre, dni, telf, email, tutor, codcurso);

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
                    }
                    if(persona.GetType() == typeof(tAlumno))
                    {
                        mListaAlumnos.RemoveAt(pos);
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
                if (persona.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }

    }
}
