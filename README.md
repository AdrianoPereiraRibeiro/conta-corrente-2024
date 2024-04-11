
# Conta Corrente

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

---
## Detalhes

Uma conta corrente possui um n�mero, um saldo, um status que informa se ela � especial ou n�o, um limite e um hist�rico de movimenta��es. Uma movimenta��o possui um valor e uma informa��o se ela � uma movimenta��o de cr�dito ou d�bito. 

Cada conta ter� opera��es de saques, dep�sitos, visualiza��o de saldo, visualiza��o de extrato e transfer�ncia entre contas.

Cada conta vai ter o nome, o sobrenome e cpf do cliente dono da conta.

Uma conta corrente s� pode fazer saques desde que o valor n�o exceda o limite de saque que � o limite + saldo.

---
## Funcionalidades

TBD

---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
git clone https://github.com/academia-do-programador/conta-corrente-2024.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd conta-corrente-2024
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd ContaCorrente.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```