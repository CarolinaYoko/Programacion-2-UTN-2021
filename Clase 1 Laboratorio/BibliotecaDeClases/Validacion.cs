﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Validacion
    {
        public static bool Validar(int valor,int min,int max)
        {
            bool respuesta = false;
			if (valor<max && valor>min)
			{
                respuesta = true;
			}
            return respuesta;
        }
    }
}
