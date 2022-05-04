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
        public void anadirAlumno(string nombre, string dni, string tlf, string codCurso)
        {
            tAlumno alumno = new tAlumno(nombre, dni, tlf, codCurso);
            mListaPersonas.Add(alumno);
            mListaAlumnos.Add(alumno);
        }
    }
}
