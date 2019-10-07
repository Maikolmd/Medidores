using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Region
    {
        private string codigoRegion;
        private string nombre;
        private string codigoTarifa;

        public string CodigoRegion
        {
            get
            {
                return codigoRegion;
            }

            set
            {
                codigoRegion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string CodigoTarifa
        {
            get
            {
                return codigoTarifa;
            }

            set
            {
                codigoTarifa = value;
            }
        }
    }
}
