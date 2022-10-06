using System.Collections.Generic;
using PIterator.Interface;

namespace PIterator.Class
{
    // Tipo concredo da coleção
    //Retorna novas instancias da classe Iterator Especifica
    public class ConcreteCollection : IAbsCollection
    {
        //Conta quantos clientes tem na lista
        public int Count { get { return listaClientes.Count;} }
        //Cria uma lista de clientes para ser manipulada internamente
        private List<Cliente> listaClientes = new();

        //Cria o Iterator - Para não precisar instanciar na main
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        //Adiciona clientes na Lista
        public void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        //Retorna um objeto cliente na posicao
        public Cliente GetCliente(int posicao)
        {
            return listaClientes[posicao];
        }
    }
}