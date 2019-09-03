using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Parabolica
    {
        public List<Muestra> Muestras { get; set; }

        public Parabolica()
        {
            Muestras = new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            resultado = (tiempo * tiempo);

            return resultado;
        }
    }
}
