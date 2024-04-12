using System.Security.Cryptography.X509Certificates;
using static ContaCorrente.ConsoleApp.Program;

namespace ContaCorrente.ConsoleApp
{
    internal partial class Program
    {
        public class Conta()
        {
            public double saldo;
            public double Valor;
            public string[] historico = new string[10];
            public int ValorAtualTransferencias;
            public int numeroDeOperacoes;
            
            public string[] Movimentacoes() 
            {Conta conta = new Conta();
                for (int i = 0; i < historico.Length; i++) 
                { 
                if (conta.historico[i] is null) { conta.historico[i] = ("O valor a operação foi de " + Valor + " agora o saldo é " + conta.saldo); }
                }
                return conta.historico;
            
            }
            public double Sacar()
            {
                Conta conta = new Conta();
                Console.WriteLine("Digite o valor do saque:");
                double saque = Convert.ToDouble(Console.ReadLine());
                if (saque > saldo) { Console.WriteLine("Essa operação é invalida!!! Você não possui saldo suficiente!"); }
                else
                {
                    
                    saldo = saldo - saque;
                    Console.Clear();
                    //Console.WriteLine("Seu saldo é igual a R$"+saldo);
                    conta.Valor = saque;
                    conta.Movimentacoes();
                }
                return conta.saldo;
            }

            public double Depositar()
            {
                Conta conta = new Conta();
                Console.WriteLine("Digite o valor do depósito:");
                double deposito = Convert.ToDouble(Console.ReadLine());
                saldo += deposito;
                //Console.WriteLine("Seu saldo é igual a R$"+saldo);
                //historico[ValorAtualDoExtrato] = ("Depósito de R$" + deposito + "\n Valor da conta = R$" + saldo);
                //ValorAtualDoExtrato++;
               Console.Clear();
                conta.Valor = deposito;
                conta.Movimentacoes();
                return conta.saldo;

            }
            public void VisualizarSaldo() 
            {
                Conta conta = new Conta();
                Console.WriteLine("Seu saldo atual é de R$" + saldo);
                Console.ReadLine();
                Console.Clear() ;
            }
            public void VisualizarExtrato() 
            {
                Conta conta = new Conta();
                Console.WriteLine("EXTRATO: ");
                for (int i = 0; i < historico.Length; i++) 
                {
                    Console.WriteLine(conta.historico[i]);                   
                }
                Console.ReadLine();
                Console.Clear ();
            }
            public double Transferir() 
            {
                Conta conta = new Conta();
                
                Console.WriteLine("Digite o valor da transferencia:");
                double transferencia = Convert.ToDouble(Console.ReadLine());
                saldo = saldo - transferencia;
                //historico[ValorAtualDoExtrato] = ("Transferencia de R$" + transferencia + "\n Valor da conta = R$" + saldo);
                //ValorAtualDoExtrato++;
                //historico[ValorAtualTransferencias] = ("Transferencia de R$" + transferencia + "\n Valor da conta = R$" + saldo);
                //ValorAtualTransferencias++; 
                Console.Clear();
                conta.Valor = transferencia;
                conta.Movimentacoes();
                return conta.saldo;
                
            }


        }

    }
}
