using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            int frota, quilometragemInicial, quilometragemFinal;
            List<Carro> carros = new List<Carro>();
            List<Barco> barcos = new List<Barco>() {
                new Barco() {NumeroCasco = "aaaa000000", Viagem = 500 },
                new Barco() {NumeroCasco = "555555bbbbbb", Viagem = 100 },
                new Barco() {NumeroCasco = "88888asdew", Viagem = 850 },
                new Barco() {NumeroCasco = "qwertyu1234", Viagem = 0 }
            };
            QuilometragemService servicoQuilometragem = new QuilometragemService();

            Console.WriteLine("Quantos carros deseja cadastrar na frota: ");
            frota = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < frota; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Veiculo {i + 1}: ");
                Console.Write("Digite a placa: ");
                placa = Console.ReadLine();
                Console.Write("Quilometragem Inicial: ");
                quilometragemInicial = int.Parse(Console.ReadLine());
                Console.Write("Quilometragem Final: ");
                quilometragemFinal = int.Parse(Console.ReadLine());
                carros.Add(new Carro(placa, quilometragemInicial, quilometragemFinal));
            }


            var maisRodadoCarro = servicoQuilometragem.MaiorQuilometragem(carros);
            Console.WriteLine();
            Console.WriteLine("Carro mais rodado: ");
            Console.WriteLine(maisRodadoCarro);

            var maisRodadoBarco = servicoQuilometragem.MaiorQuilometragem(barcos);

            Console.WriteLine();
            Console.WriteLine("Barco mais rodado: ");
            Console.WriteLine(maisRodadoBarco);
        }
    }
}
