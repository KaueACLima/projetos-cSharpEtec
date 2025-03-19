using System;

namespace ControleComissao
{
    class Principal
    {
        static void Main(string[] args)
        {
            ControleComissao cc1 = new ControleComissao();

            Console.WriteLine("Digite seu nome: ");
            cc1.setNome(Console.ReadLine());
            Console.WriteLine("Digite seu salário base: ");
            cc1.setSalarioBase(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o valor das vendas: ");
            


            // Mostrar usuário

            Console.WriteLine("Seu nome é : " + cc1.getNome());
            Console.WriteLine("Seu seu salário é : " + cc1.getSalarioBase());
            Console.WriteLine("O valor total das vendas é : " + cc1.getValorVendas());
            cc1.calcularComissao(1500);
        }
    }
}
