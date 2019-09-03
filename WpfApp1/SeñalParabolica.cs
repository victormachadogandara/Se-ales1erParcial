﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class SeñalParabolica
    {
        public List<Muestra> Muestras { get; set; }

        public SeñalParabolica()
        {
            Muestras = new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            if (tiempo >= 0)
            {
                resultado = (tiempo * tiempo) / 2;
            }
            else
            {
                resultado = 0.0;
            }

            return resultado;
        }
    }
}
