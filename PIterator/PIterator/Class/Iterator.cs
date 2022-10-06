using System.Linq;
using PIterator.Interface;

namespace PIterator.Class
{
    public class Iterator : IIterator
    {
        //Propriedade PosicaoAtual é a posicao do cliente na lista
        private int posicaoAtual = 0;
        //Aux é um somador de posições
        private int aux = 1;
        //IsDone retorna se a lista chegou ao final
        public bool IsDone {get { return posicaoAtual >= collection.Count; } }

        private ConcreteCollection collection;

        //Recebe um coleção concreta
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        //retorna o primeiro item da lista
        public Cliente First()
        {
            posicaoAtual = 0;
            return collection.GetCliente(posicaoAtual);
        }
        // Retorna o proximo item da lista
        public Cliente Next()
        {
            posicaoAtual += aux;
            if (!IsDone)
            {
                return collection.GetCliente(posicaoAtual);
            }
            return null;
        }

        

    }
}
