using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Carro : IComparable
    {
        public string Placa { get; set; }
        public int QuilometragemInicial { get; set; }
        public int QuilometragemFinal { get; set; }
        public int Viagem { get; private set; }
        public Carro()
        {

        }

        public Carro(string placa, int quilometragemInicial, int quilometragemFinal)
        {
            Placa = placa;
            QuilometragemInicial = quilometragemInicial;
            QuilometragemFinal = quilometragemFinal;
            Viagem = QuilometragemFinal - QuilometragemInicial;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Carro))
            {
                throw new ArgumentException("O argumeno fornecido nao e um carro");
            }
            Carro outroCarro = obj as Carro;

            return Viagem.CompareTo(outroCarro.Viagem);
        }
        public override string ToString()
        {
            StringBuilder infoCarro = new StringBuilder();
            infoCarro.AppendLine($"Placa: {Placa}");
            infoCarro.AppendLine($"Quilometragem Inicial: {QuilometragemInicial}");
            infoCarro.AppendLine($"Quilometragem Final: {QuilometragemFinal}");
            infoCarro.AppendLine($"Viagem: {Viagem}");
            return infoCarro.ToString();
        }
    }
}
