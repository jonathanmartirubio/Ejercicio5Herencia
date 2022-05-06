using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class tAlumno : tPersona
    {
        private List<double> mNotas;
        private int mCodigoCurso;

        public tAlumno(string dni, string nombre, string telf, int CodCurso) : base(dni, nombre, telf)
        {
            mCodigoCurso = CodCurso;
            mNotas = new List<double>();
        }
        public int CodigoCurso
        {
            set { mCodigoCurso = value; }
            get { return mCodigoCurso; }
        }

        private string MostrarNotas()
        {
            string texto;

            if (mNotas.Count > 0)
            {
                texto = "";
                for (int i = 0; i < mNotas.Count; i++)
                {
                    texto += mNotas[i] + ", ";
                }
            }
            else
            {
                texto = "Alumno sin notas.\n";
            }
            return texto;
        }

        public override string MostrarDatos()
        {
            string texto;

            texto = "Datos del Alumno: \n";
            texto += base.MostrarDatos();
            texto += "Curso: " + mCodigoCurso + "\n";
            texto += "Notas: " + MostrarNotas() + "\n";

            return texto;

        }

        public void AnyadirNota(double nota)
        {
            if (nota >= 0)
            {
                mNotas.Add(nota);
            }
        }

        public void EliminarNotas()
        {
            mNotas.Clear();
        }

        public bool TieneNotas()
        {
            bool tienenotas;

            tienenotas = false;

            if (mNotas.Count > 0)
            {
                tienenotas = true;
            }

            return tienenotas;
        }

        public double NotaMedia()
        {
            double media;
            double total;

            total = 0;

            for (int i = 0; i < mNotas.Count; i++)
            {
                total += mNotas[i];
            }

            media = total / mNotas.Count;

            return media;
        }
    }
}
