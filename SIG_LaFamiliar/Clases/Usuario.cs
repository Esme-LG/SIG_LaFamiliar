using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_LaFamiliar.Clases
{
    class Usuario
    {
        private int _id;
        private string _nombre;
        private string _rol;
        private string _cuenta;

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string rol
        {
            get
            {
                return _rol;
            }
            set
            {
                _rol = value;
            }
        }

        public string cuenta
        {
            get
            {
                return _cuenta;
            }
            set
            {
                _cuenta = value;
            }
        }
    }
}
