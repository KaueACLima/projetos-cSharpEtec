using System;
using System.Collections.Generic;
using System.Text;

namespace ControleComissaoRevisaoProva
{
    // Classe de manipulação do objeto
    class Principal
    {
        static void Main(string[] args)
        {
            // Método Contrutor
            Vendedor vendedor1 = new Vendedor();

            // Inserindo dados no objeto
            Console.WriteLine("Digite seu nome:");
            vendedor1.setNome(Console.ReadLine());
            Console.WriteLine("Digite seu salário base:");
            vendedor1.setSalarioBase(Convert.toDouble(Console.ReadLine()));

            // Exibir os dados
            Console.WriteLine(vendedor1.getNome());
            Console.WriteLine(vendedor1.getSalarioBase());
        }
    }
}
