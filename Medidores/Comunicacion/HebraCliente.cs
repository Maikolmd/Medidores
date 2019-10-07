using MedidoresModel;
using MedidoresModel.DAL;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidores.Comunicacion
{
    class HebraCliente
    {
        private ClienteCom clienteCom;
        private ILecturasDAL lecturasDAL = LecturasDALArchivos.GetInstancia();
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();

        public HebraCliente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }

        public void Ejecutar()
        {
            string mensaje;
            mensaje = clienteCom.Leer();
            string[] textoArr = mensaje.Trim().Split('|');
            int idMedidor = Convert.ToInt32(textoArr[0]);
            DateTime fecha = DateTime.ParseExact(textoArr[1], "yyyy-MM-dd-HH-mm-ss", null);
            decimal valorConsumo = Convert.ToDecimal(textoArr[2]);

            Lectura l = new Lectura()
            {
                IdMedidor = idMedidor,
                Fecha = fecha,
                ValorConsumo = valorConsumo
            };
            List<Medidor> medidores = medidoresDAL.ObtenerMedidor().FindAll(m => m.Id == idMedidor);
            if (medidores.Count > 0)
            {
                lock (lecturasDAL)
                {
                    lecturasDAL.IngresarLectura(l);
                }
                clienteCom.Escribir("OK");
            }
            else
            {
                clienteCom.Escribir("ERROR");
            }
            
            clienteCom.Desconectar();
        }
    }
}
