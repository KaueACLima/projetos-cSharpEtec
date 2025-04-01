using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularAreasProva
{
    class Triagulo
    {
        private double basee;
        private double altura;

        // setBasee
        public void setBasee(double basee)
        {
            this.basee = basee;
        }

        // getBasee
        public double getBasee()
        {
            return basee;
        }

        // setAltura
        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        // getAltura
        public double getAltura()
        {
            return altura;
        }

        public double calcularArea(double basee, double altura)
        {
            return (basee * altura) / 2;
        }
    }
}
