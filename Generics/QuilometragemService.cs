using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class QuilometragemService
    {
        public QuilometragemService()
        {
                
        }

        public T MaiorQuilometragem<T>(List<T> list) where T: IComparable
        {
            T maisRodado = list[0];
            if (list.Count == 0)
            {
                throw new ArgumentException("Nao e possivel enviar uma lista vazia");
            }
            foreach (T veiculo in list)
            {
                if(veiculo.CompareTo(maisRodado) > 0)
                {
                    maisRodado = veiculo;
                }
                
            }
            return maisRodado;
        }
    }
}
