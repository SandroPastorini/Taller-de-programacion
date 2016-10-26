﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej04
{
    class Shell
    {
        public static void iniciar()
        {
            Fachada.instanciarFabrica();
            Console.WriteLine("============ ENCRIPTOMATICO ============");
            Console.WriteLine("\n1) Encriptar Cesar\n2) Desencriptar Cesar");

            int opcion = Console.Read();
            switch (opcion)
            {
                case 1: Fachada.Encriptar("César");
                    break;
                case 2: Fachada.Desencriptar("César");
                    break;
                default:
                    Console.WriteLine("Gracias por usar el programa! :) por favor no vuelva. Nunca. Jamas.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
