using System;
using System.Collections.Generic;
using System.Text;

namespace ControleComissaoRevisaoProva
{
    class Principal
    {
        // Classe de manipulação do objeto
        static void Main(string[] args)
        {
            // Método Contrutor
            Vendedor vendedor1 = new Vendedor();

            // Inserindo dados no objeto
            Console.WriteLine("Digite seu nome:");
            vendedor1.setNome(Console.ReadLine());

            Console.WriteLine("Digite seu salário base:");
            vendedor1.setSalarioBase(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite digite o valor vendido:");
            double valorVendido = (Convert.ToDouble(Console.ReadLine()));

            // Exibir os dados
            Console.WriteLine("Seu nome é: " + vendedor1.getNome());
            Console.WriteLine("Seu salário base é: " + vendedor1.getSalarioBase());

            // Chamando (invocando) o método específico da classe
            Console.WriteLine("O valor da sua comissão: " + vendedor1.calcularComissao(valorVendido));

            Console.WriteLine("Seu salário atual é: " + (vendedor1.getSalarioBase() + vendedor1.calcularComissao(valorVendido)));
        }
    }
}
