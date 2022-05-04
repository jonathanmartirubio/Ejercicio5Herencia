﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    abstract class tPersona
    {
        private string mDni;
        private string mNombre;
        private string mTelefono;

        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public tPersona(string dni, string nombre, string telf)
        {
            mDni = dni;
            mNombre = nombre;
            mTelefono = telf;
        }
    }
}
