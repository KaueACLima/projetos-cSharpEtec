using System;

namespace ContaCorrente
{
    class ContaCorrente
    {
        // Atributos
        public string nome;
        public string cpf;
        public double limiteCredito;
        public double saldo;
        public bool negativado;
        public int valor;

        // Método depositar
        public void depositar()
        {

            Console.WriteLine("Novo saldo: " + (saldo = valor + saldo));
        }

        // Método depositar
        public void sacar()
        {
            Console.WriteLine("Valor sacado: " + (saldo = valor - saldo));
        }

        // Método depositar
        public void verSaldo()
        {
            Console.WriteLine("Nome do Cliente: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Saldo atual: " + saldo);
        }

        static void Main(string[] args)
        {
            // Intanciar
            ContaCorrente conta = new ContaCorrente();

            // Atribuido valores
            conta.nome = "Kauê";
            conta.cpf = "1345678999";
            conta.limiteCredito = 800;
            conta.saldo = 500;
            conta.negativado = false;
            conta.valor = 1000;

            // Exibindo na tela
            Console.WriteLine("Bem vindo ao Banco Acredite - Aqui fazemos você ter crédito!");
            Console.WriteLine("Seu limite de crédito: " + conta.limiteCredito);

            // Chamando métodos
            Console.WriteLine("Valor depositado " + conta.valor);
            conta.verSaldo();
            conta.depositar();
            conta.sacar();


        }
    }
}
