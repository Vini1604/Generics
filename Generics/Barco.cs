using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Barco : IComparable
    {
        public string NumeroCasco { get; set; }
        public int Viagem { get; set; }

        public Barco()
        {

        }

        public Barco(string numeroCasco, int viagem)
        {
            NumeroCasco = numeroCasco;
            Viagem = viagem;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Barco))
            {
                throw new ArgumentException("O argumeno fornecido nao e um barco");
            }
            Barco outroBarco = obj as Barco;

            return Viagem.CompareTo(outroBarco.Viagem);
        }
        public override string ToString()
        {
            StringBuilder infoCarro = new StringBuilder();
            infoCarro.AppendLine($"Numero do Casco: {NumeroCasco}");
            infoCarro.AppendLine($"Viagem: {Viagem}");
            return infoCarro.ToString();
        }
    }
}
