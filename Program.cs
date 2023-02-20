using DesafioEstacionamento.Models;
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

System.Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n" + "Digite o preço Inicial:");
precoInicial = Convert.ToDecimal(System.Console.ReadLine());


System.Console.WriteLine("Agora digite o preço por hora :");
precoPorHora = Convert.ToDecimal(System.Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.EstacionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}
Console.WriteLine("O programa se encerrou");
