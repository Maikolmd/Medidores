using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Lectura
    {
        private DateTime fecha;
        private decimal valorConsumo;
        private int idMedidor;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public decimal ValorConsumo
        {
            get
            {
                return valorConsumo;
            }

            set
            {
                valorConsumo = value;
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

        public override string ToString()
        {
            return IdMedidor
                + " "
                + fecha + " "
                + ValorConsumo;
        }
    }
}
