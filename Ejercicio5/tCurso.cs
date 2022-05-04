using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class tCurso
    {
        private int mCodigo;
        private string mNombre;

        public tCurso()
        {
            mNombre = "";
        }

        public int Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string MostrarDatos()
        {
            string texto;

            texto = "Datos del curso:\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Código: " + mCodigo + "\n";

            return texto;
        }
    }
}
