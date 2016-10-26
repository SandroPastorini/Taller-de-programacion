﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej03
{
    public class EvaluadorSueldo : IEvaluador
    {
        double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            if (pSolicitud.Cliente.Empleo.Sueldo <= iSueldoMinimo)
                return true;

            return false;
        }
    }
}
