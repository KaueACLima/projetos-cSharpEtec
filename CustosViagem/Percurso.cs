using System;
using System.Collections.Generic;
using System.Text;

namespace CustosViagem
{
    class Percurso
    {

        private double kmPercorrido;
        private double valorCombustivel;
        private double valorPedagio;
        private string nomePercurso;


        public void cadastrarPercurso(string nomePercurso, double kmPercorrido, double valorCombustivel, double valorPedagio)
        {
            this.nomePercurso = nomePercurso;
            this.kmPercorrido = kmPercorrido;
            this.valorCombustivel = valorCombustivel;
            this.valorPedagio = valorPedagio;
        }

        public string listaPercurso()
        {
            return "Para onde deseja viajar: " + nomePercurso +
                "\n Quilômetro percorrido: " + Convert.ToString(kmPercorrido) +
                "\n Valor do combustível: " + Convert.ToString(valorCombustivel) +
                "\n Valor do pedágio: " + Convert.ToString(valorPedagio);
        }

        // getkmPercorrido
        public double getKmPercorrido()
        {
            return kmPercorrido;
        }

        // getvalorCombustivel
        public double getValorCombustivel()
        {
            return valorCombustivel;
        }

        // getValorPedagio
        public double getValorPedagio()
        {
            return valorPedagio;
        }
    }
}
