using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial; 
            this.precoPorHora = precoPorHora;
        }
        public void EstacionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placaDigitada = Console.ReadLine();

            veiculos.Add(placaDigitada.ToUpper());
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            var placa = Console.ReadLine();
            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                var horas = int.Parse(Console.ReadLine());

                decimal valorTotal = this.precoInicial + this.precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo de placa {placa} foi removido e o valor total foi de R$:{valorTotal}");
            }
            
            
        }
        public void ListarVeiculos ()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
  
    }
}