using System;

namespace Lampada
{
    class Lampada
    {
        // Atributos
        public int lampadaNro;
        public string comodo;
        public bool status;

        // Método
        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu existo");
        }

        static void Main(string[] args)
        {
            // Método construtor
            Lampada l1 = new Lampada();

            // Invocar o método provarExistencia()
            l1.provarExistencia();

            // Inserindo dados no objeto (instância)
            l1.lampadaNro = 1;
            l1.comodo = "Lab1";
            l1.status = true;

            //Exibindo dados do objeto
            Console.WriteLine("Número de lâmpada: " + l1.lampadaNro);
            Console.WriteLine("Cômodo: " + l1.comodo);
            Console.WriteLine("Status: " + l1.status);
        }
    }
}
