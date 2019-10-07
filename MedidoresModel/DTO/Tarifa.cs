using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Tarifa
    {
        private string codigo;
        private string factor;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Factor
        {
            get
            {
                return factor;
            }

            set
            {
                factor = value;
            }
        }
    }
}
