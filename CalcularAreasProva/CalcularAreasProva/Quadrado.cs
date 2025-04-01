using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreasProva
{
    class Quadrado
    {
        private double lado;

        // setLado
        public void setLado(double lado)
        {
            this.lado = lado;
        }

        // getLado
        public double getLado()
        {
            return lado;
        }

        public double calcularArea(double lado)
        {
            return lado * lado;
        }
    }
}
