using System;

namespace CalcularAreasProva
{
    class Principal
    {
        static void Main(string[] args)
        {
            Quadrado quadrado1 = new Quadrado();

            Console.WriteLine("Digite o lado do quadrado:");
            quadrado1.setLado(Convert.ToDouble(Console.ReadLine()));

            quadrado1.calcularArea(quadrado1.getLado());

            Console.WriteLine("A área do quadrado é :" + quadrado1.calcularArea(quadrado1.getLado()));

            // ---------------------Fim Quadrado-------------------------

            Triagulo triagulo1 = new Triagulo();

            Console.WriteLine("Digite a base do triagulo:");
            triagulo1.setBasee(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite a altura do triagulo:");
            triagulo1.setAltura(Convert.ToDouble(Console.ReadLine()));

            triagulo1.calcularArea(triagulo1.getBasee(), triagulo1.getAltura());

            Console.WriteLine("A área do triangulo é :" + triagulo1.calcularArea(triagulo1.getBasee(),triagulo1.getAltura()));

            // ---------------------Fim Triagulo-------------------------

            Circulo circulo1 = new Circulo();

            Console.WriteLine("Digite o raio do circulo:");
            circulo1.setRaio(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("O raio do circulo é:" + circulo1.calcularArea(circulo1.getRaio()));

            // ---------------------Fim Circulo-------------------------
        }
    }
}
