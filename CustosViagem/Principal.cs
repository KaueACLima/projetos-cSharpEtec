using System;

namespace CustosViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Percurso p1 = new Percurso();

            Console.WriteLine("Para onde deseja viajar: ");
            string nomePercurso = Console.ReadLine();

            Console.WriteLine("Digite quantos quilômetros para viajar: ");
            double kmPercorrido = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite o valor do combustível: ");
            double valorCombustivel = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite o valor do pedágio: ");
            double valorPedagio = (Convert.ToDouble(Console.ReadLine()));

            p1.cadastrarPercurso(nomePercurso, kmPercorrido, valorCombustivel, valorPedagio);
            p1.listaPercurso();



        }
    }
}
