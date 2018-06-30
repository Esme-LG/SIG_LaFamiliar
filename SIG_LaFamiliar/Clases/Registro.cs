using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_LaFamiliar.Clases
{
    class Registro
    {
        private DateTime _fecha;
        private string _usuario;
        private string _politica;

        public DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value; 
            }
        }

        public string usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public string politica
        {
            get
            {
                return _politica;
            }
            set
            {
                _politica = value;
            }
        }
    }
}
