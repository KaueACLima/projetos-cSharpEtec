using System;

namespace ControleComissaoRevisaoProva
{
    // Classe de Modelagem do objeto
    class Vendedor
    {
        private string nome;
        private double salarioBase;

        // getter´s setter´s

        // setNome
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        // getNome
        public string getNome()
        {
            return nome;
        }

        // setNome
        public void setSalarioBase(double salarioBase)
        {
            this.salarioBase = salarioBase;
        }

        // getNome
        public double getSalarioBase()
        {
            return salarioBase;
        }

        // Método específico da classe
        public double calcularComissao(double valorVendido)
        {
             return valorVendido * 0.03;
        }

        // Método não específico da classe
        public void calcularComissao2(double valorVendido)
        {
            double comissao = valorVendido * 0.03;
        }
    }
}
