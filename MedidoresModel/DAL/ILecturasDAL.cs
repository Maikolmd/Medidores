﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturasDAL
    {
        void IngresarLectura(Lectura lectura);

        List<Lectura> ObtenerLecturas();
    }
}
