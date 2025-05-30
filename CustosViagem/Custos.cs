using System;
using System.Collections.Generic;
using System.Text;

namespace CustosViagem
{
    class Custos
    {

        private double totalPercurso;

        public void calcularViagem(Percurso p1)
        {
            totalPercurso = (p1.getKmPercorrido() / 10) * p1.getValorCombustivel() + p1.getValorPedagio();
            Console.WriteLine("O Custo total da viagem é: " + totalPercurso);
        }
    }
}
