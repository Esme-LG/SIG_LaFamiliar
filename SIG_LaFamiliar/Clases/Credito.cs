using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_LaFamiliar.Clases
{
    class Credito
    {
        private string _codigo;
        private string _asociado;
        private decimal _cuota;
        private decimal _interes;
        private decimal _saldo;
        private decimal _mora;

        public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public string asociado
        {
            get
            {
                return _asociado;
            }
            set
            {
                _asociado  = value;
            }
        }

        public decimal cuota
        {
            get
            {
                return _cuota;
            }

            set
            {
                _cuota = value; 
            }
        }

        public decimal interes
        {
            get
            {
                return _interes;
            }

            set
            {
                _interes = value;
            }
        }

        public decimal saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                _saldo = value;
            }
        }

        public decimal mora
        {
            get
            {
                return _mora;
            }

            set
            {
                _mora = value;
            }
        }
    }
}
