using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Direccion
    {
        private int id;
        private string descripcion;
        private int numero;
        private string codigoRegion;
        private string codigoCliente;
        private int idMedidor;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

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

        public string CodigoCliente
        {
            get
            {
                return codigoCliente;
            }

            set
            {
                codigoCliente = value;
            }
        }

        public int IdMedidor
        {
            get
            {
                return idMedidor;
            }

            set
            {
                idMedidor = value;
            }
        }
    }
}
