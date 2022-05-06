using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class tProfesor : tPersona
    {
        private List<string> mAsignaturas;
        private bool mTutor;
        private int mCodigoCurso;
        private string mEmail;

        public tProfesor(string dni, string nombre, string telf, string email, bool tutor, int codcurso) : base (dni, nombre, telf)
        {
            mAsignaturas = new List<string>();
            mEmail = email;
            mTutor = tutor;
            mCodigoCurso = codcurso;
        }

        public bool Tutor
        {
            set { mTutor = value; }
            get { return mTutor; }
        }

        public int CodigoCurso
        {
            set { mCodigoCurso = value; }
            get { return mCodigoCurso; }
        }

        public string Email
        {
            set { mEmail = value; }
            get { return mEmail; }
        }
        public void AnyadirAsignatura(string asignatura)
        {
            mAsignaturas.Add(asignatura);
        }

        public bool ImparteAsignatura(string asignatura)
        {
            bool imparte;
            imparte = false;

            for (int i = 0; i < mAsignaturas.Count; i++)
            {
                if (mAsignaturas[i] == asignatura)
                {
                    imparte = true;
                }
            }

            return imparte;
        }

        private string MostrarAsignaturas()
        {
            string texto;

            if (mAsignaturas.Count > 0)
            {
                texto = "";
                for (int i = 0; i < mAsignaturas.Count; i++)
                {
                    texto += mAsignaturas[i] + ", ";
                }
            }
            else
            {
                texto = "Profesor sin asignaturas.\n";
            }
            return texto;
        }

        public void EliminarAsignaturas()
        {
            mAsignaturas.Clear();
        }

        public override string MostrarDatos()
        {
            string texto;

            texto = "Datos del Profesor:\n";
            texto += base.MostrarDatos();
            texto += "Asignaturas: " + MostrarAsignaturas() + "\n";
            if (mTutor)
            {
                texto += "Tutor de: " + mCodigoCurso + "\n";
            }
            else
            {
                texto += "No es tutor de ninguna asignatura.";
            }

            return texto;
        }
    }
}
