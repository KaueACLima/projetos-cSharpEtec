using System;

namespace Usuario
{
    class Usuario
    {
        //Atritubutos
        public string nome;
        public string email;
        public string login;
        public string senha;

        //Método específico da classe
        public void provarExististencia()
        {
            Console.WriteLine("Prova de existencia: Oi, eu existo");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá mundo!");

            // Método construtor
            // NomeDaClasse | NomeDaInstÂncia | = | comando new | método constutor()
            Usuario u1 = new Usuario();  // Vai ser sempre o mesmo nome da classe

            // Invocar o método provarExistencia()
            // nomeDaInstancia.nomeDoMetodo

            u1.provarExististencia();

            // Inserindo dados no objeto (instância)
            u1.nome = "Kauê Lima";
            u1.email = "@e@";
            u1.login = "kaueL";
            u1.senha = "1234";

            // Exibindo os dados do objeto
            // Console.WriteLine(nomeDaInstacia.atributo)
            Console.WriteLine("Objeto Usuário");
            Console.WriteLine("Nome: " + u1.nome);
            Console.WriteLine("Email: " + u1.email);
            Console.WriteLine("Usuário: " + u1.login);
            Console.WriteLine("Senha: " + u1.senha);
        }
    }
}
