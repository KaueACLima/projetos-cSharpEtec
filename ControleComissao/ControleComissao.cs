using System;
using System.Collections.Generic;
using System.Text;

namespace ControleComissao
{
    class ControleComissao
    {
        private string nome;
        private double salarioBase;
        private double comissao;
        private double valorVendas;

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

        // setComissao
        public void setComissao(double comissao)
        {
            this.comissao = comissao;
        }

        // getComissao
        public double getComissao()
        {
            return comissao;
        }

        // setSalarioBase
        public void setSalarioBase(double salarioBase)
        {
            this.salarioBase = salarioBase;
        }

        // getSalarioBase
        public double getSalarioBase()
        {
            return salarioBase;
        }

        // setvalorVendas
        public void setValorVendas(double valorVendas)
        {
            this.valorVendas = valorVendas;
        }

        // getValorVendas
        public double getValorVendas()
        {
            return valorVendas;
        }

        public double calcularComissao(double valorVendido)
        {
            comissao =  valorVendido * 0.03;
            Console.WriteLine("Sua comissão é: " + comissao);
            return valorVendido;
        }

    }
}
