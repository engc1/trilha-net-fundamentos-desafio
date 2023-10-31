using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models;
public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Console.ReadLine();
        if (veiculos.Contains(placa))
        {
            veiculos.Remove(placa);
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento:");
            int horas = Convert.ToInt32(Console.ReadLine());
            decimal total = precoInicial + (precoPorHora * horas);
            Console.WriteLine($"O total a pagar é: {total}");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado.");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
        else
        {
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}