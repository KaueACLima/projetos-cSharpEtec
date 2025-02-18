using System;

namespace LampadaDois
{
    class LampadaDois
    {
        // Atributos
        public int lampadaNro;
        public string comodo;
        public bool status;

        //Método específico da classe
        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu existo");
        }

        static void Main(string[] args)
        {
            // Método construtor
            // NomeDaClasse | NomeDaInstÂncia | = | comando new | método constutor()
            LampadaDois l2 = new LampadaDois();

            // Invocar o método provarExistencia()
            // nomeDaInstancia.nomeDoMetodo
            l2.provarExistencia();

            // Inserindo dados no objeto (instância)
            l2.lampadaNro = 1;
            l2.comodo = "Lab1";
            l2.status = true;

            // Exibindo os dados do objeto
            // Console.WriteLine(nomeDaInstacia.atributo)
            Console.WriteLine("Número de lâmpada: " + l2.lampadaNro);
            Console.WriteLine("Cômodo: " + l2.comodo);
            Console.WriteLine("Status: " + l2.status);
        }
    }
}
