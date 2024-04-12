using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ContaCorrente.ConsoleApp
{
    internal partial class Program
    {
        public class Usuario() 
        {
            public string nome;
            public string cpf;
            public string sobrenome;
            public void  ColetarInformacoes() {
                
                Console.WriteLine("Digite o seu primeiro nome:");
               nome= Console.ReadLine();
                Console.WriteLine("Digite o seu sobrenome:");
                sobrenome = Console.ReadLine();
                Console.WriteLine("Digite seu CPF:");
                cpf= Console.ReadLine();
                Console.WriteLine("Bem-Vindo "+nome);
            }
        
        }
    }
}
