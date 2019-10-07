using Medidores.Comunicacion;
using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Medidores
{
    class Program
    {
       private static ILecturasDAL lecturasDAL = LecturasDALArchivos.GetInstancia();
       private static IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    Agregar();
                    break;
                case "2":
                    Mostrar();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Ingrese de nuevo");
                    break;
            }
            return continuar;
        }

        static void Main(string[] args)
        {
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.IsBackground = true;
            t.Start();
            while (Menu()) ;
        }

        static void Mostrar()
        {
            List<Lectura> lecturas = null;
            lock (lecturasDAL)
            {
                lecturas = lecturasDAL.ObtenerLecturas();
            }
            foreach (Lectura lectura in lecturas)
            {
                Console.WriteLine(lectura);
            }
        }
        

        static void Agregar()
        {
            
            bool validado;
            int idMedidor;
            DateTime fecha;
            decimal consumo;

            Lectura lectura = new Lectura();

            do
            {
                Console.WriteLine("Ingrese id del medidor: ");
                validado = Int32.TryParse(Console.ReadLine().Trim(), out idMedidor);
            } while (!validado);
            lectura.IdMedidor = idMedidor;

            do
            {
                Console.WriteLine("Ingrese fecha: ");
                validado = DateTime.TryParse(Console.ReadLine().Trim(), out fecha);
            } while (!validado);
            lectura.Fecha = fecha;
            do
            {
                Console.WriteLine("Ingrese consumo: ");
                validado = Decimal.TryParse(Console.ReadLine().Trim(), out consumo);
            } while (!validado);
            lectura.ValorConsumo = consumo;

            if (medidoresDAL.CompararId(idMedidor).Count != 0)
            {
                lecturasDAL.IngresarLectura(lectura);
                Console.WriteLine("Lectura ingresada");
            }
            else
            {
                Console.WriteLine("ERROR: No se a encontrado el medidor");
            }

        }
    }
}
