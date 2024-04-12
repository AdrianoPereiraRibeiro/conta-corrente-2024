namespace ContaCorrente.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
              double saldo = 2000;
        Console.WriteLine("CONTA-CORENTE");
            Usuario usuario = new Usuario();
           usuario.ColetarInformacoes();
          Conta conta = new Conta();
            conta.saldo = 2000;
            //conta.ValorAtualTransferencias = 0;
            //conta.ValorAtualDoExtrato = 0;
            //conta.numeroDeOperacoes = 0;          
            while(true)
            {
                Console.WriteLine("0-Sacar \n1-Depositar \n2-Transferir \n3-Visualizar Extrato \n4-Visualizar Saldo\n6-Sair");
                Console.WriteLine("Digite a opção desejada: ");
                int opçaoMenu = Convert.ToInt32(Console.ReadLine());
                if (opçaoMenu == 6 ) { break; }
                else if (opçaoMenu < 0 || opçaoMenu > 6) { Console.WriteLine("Essa opção é invalida!!!"); }
                switch (opçaoMenu)
                {
                    case 0:
                        conta.Sacar();                       
                        break;
                        case 1:
                        conta.Depositar();                        
                        break;
                        case 2:
                        conta.Transferir();                        
                        break;
                        case 3:
                        conta.VisualizarExtrato();
                        break;
                        case 4:
                        conta.VisualizarSaldo();                      
                        break;
                        
                        

                }
            } 
        }
    }
}
