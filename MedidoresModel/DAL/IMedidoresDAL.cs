using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    
    public interface IMedidoresDAL
    {
        List<Medidor> CompararId(int id);
        List<Medidor> ObtenerMedidor();
        Medidor Obtener(int id);
        void AgregarMedidor(Medidor medidor);

        void EliminarMedidior(int id);
    }
}
