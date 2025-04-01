using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreasProva
{
    class Circulo
    {
        private double raio;

        // setRaio
        public void setRaio(double raio)
        {
            this.raio = raio;
        }

        // getNome
        public double getRaio()
        {
            return raio;
        }

        public double calcularArea(double raio)
        {
            return 3.14 * (raio * raio);
        }
    }
}
