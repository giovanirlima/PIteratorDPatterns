using System;
using PIterator.Class;

namespace PIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DESIGN PATTERNS ITERATOR");
            Console.WriteLine("\n1 - ENTENDA O DESIGN PATTERNS ITERATOR");
            Console.WriteLine("2 - EXEMPLO SIMPLES");
            Console.Write("\nOPÇÃO: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 2)
            {
                Console.Clear();

                // Cria uma coleção de objetos
                ConcreteCollection colecao = new ConcreteCollection();

                colecao.AddCliente(new Cliente(1, "Joaquim"));
                colecao.AddCliente(new Cliente(2, "Mário"));
                colecao.AddCliente(new Cliente(3, "Pedro"));
                colecao.AddCliente(new Cliente(4, "Maria"));
                colecao.AddCliente(new Cliente(5, "Manoel"));
                colecao.AddCliente(new Cliente(6, "Miriam"));
                colecao.AddCliente(new Cliente(7, "Jefferson"));

                // Cria o iterator que vai encapsular a iteração
                Iterator iterator = colecao.CreateIterator();

                Console.WriteLine("//////////////////////////////");
                Console.WriteLine("// Usando o padrão Iterador //");
                Console.WriteLine("//////////////////////////////");

                //  iterator      
                Console.WriteLine("\nIterando sobre a coleção de Clientes\n ");
                //Condição para impressão do proximo item da lista
                for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
                {
                    Console.WriteLine($"ID CLIENTE: {cliente.Id} & NOME CLIENTE: {cliente.Nome}");
                }
                Console.Read();
                return;
            }

            Console.Clear();

            Console.WriteLine("DESIGN PATTERNS ITERATOS");

            Console.WriteLine("\nO Iterator é um padrão de projeto comportamental que permite a você, percorrer");
            Console.WriteLine("elementos de uma coleção, sem expor as representações dela (lista, pilha, árvore, etc.)");
            Console.Read();
            Console.Clear();
            Console.WriteLine("PROBLEMA");
            Console.WriteLine("\nColeções são um dos tipos de dados mais usados em programação. Não obstante, uma coleção");
            Console.WriteLine("é apenas um contêiner para um grupo de objetos.");
            Console.Read();

            Console.WriteLine("\nExempo: https://imgur.com/TQlfCLT\n");

            Console.ReadKey();

            Console.WriteLine("A maioria das coleções armazena seus elementos em listas simples. Contudo, alguns deles são");
            Console.WriteLine("baseados em pilhas, árvores, grafos, e outras estruturas complexas de dados.");
            Console.WriteLine("\nMas independente de quão complexa uma coleção é estruturada, ela deve fornecer uma");
            Console.WriteLine("maneira de acessar seus elementos para que outro código possa usá-los. Deve haver uma");
            Console.WriteLine("maneira de ir de elemento em elemento na coleção sem ter que acessar os mesmos elementos");
            Console.WriteLine("repetidamente.");

            Console.Read();

            Console.Clear();

            Console.WriteLine("PROBLEMA");

            Console.WriteLine("\nIsso parece uma tarefa fácil se você tem uma coleção baseada numa lista. Você faz um loop em");
            Console.WriteLine("todos os elementos. Mas como você faz a travessia dos elementos de uma estrutura de dados");
            Console.WriteLine("complexas sequencialmente, tais como uma árvore. Por exemplo, um dia você pode apenas");
            Console.WriteLine("precisar percorrer em profundidade em uma árvore. No dia seguinte você pode precisar");
            Console.WriteLine("percorrer na amplitude. E na semana seguinte, você pode precisar algo diferente, como um");
            Console.WriteLine("acesso aleatório aos elementos da árvore.");

            Console.WriteLine("\nExemplo: https://imgur.com/an49nFU");

            Console.ReadKey();

            Console.WriteLine("\nAdicionando mais e mais algoritmos de travessia para uma coleção gradualmente desfoca sua");
            Console.WriteLine("responsabilidade primária, que é um armazenamento de dados eficiente. Além disso, alguns");
            Console.WriteLine("algoritmos podem ser feitos para aplicações específicas, então incluí-los em uma coleção");
            Console.WriteLine("genérica pode ser estranho.");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("SOLUÇÃO");
            Console.WriteLine("\nA ideia principal do padrão Iterator é extrair o comportamento de travessia de uma coleção");
            Console.WriteLine("para um objeto separado chamado um iterador.");

            Console.WriteLine("\nExemplo: https://imgur.com/u2xwDUX");

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("SOLUÇÃO");
            Console.WriteLine("\nAlém de implementar o algoritmo em si, um objeto iterador encapsula todos os detalhes da");
            Console.WriteLine("travessia, tais como a posição atual e quantos elementos faltam para chegar ao fim. Por causa");
            Console.WriteLine("disso, alguns iteradores podem averiguar a mesma coleção ao mesmo tempo,");
            Console.WriteLine("independentemente um do outro.");

            Console.Read();

            Console.WriteLine("\nGeralmente, os iteradores fornecem um método primário para pegar elementos de uma");
            Console.WriteLine("coleção. O cliente pode manter esse método funcionando até que ele não retorne mais nada, o");
            Console.WriteLine("que significa que o iterador atravessou todos os elementos.");

            Console.Read();

            Console.WriteLine("\nTodos os iteradores devem implementar a mesma interface. Isso faz que o código cliente seja");
            Console.WriteLine("compatível com qualquer tipo de coleção ou qualquer algoritmo de travessia desde que haja");
            Console.WriteLine("um iterador apropriado. Se você precisar de uma maneira especial para a travessia de uma");
            Console.WriteLine("coleção, você só precisa criar uma nova classe iterador, sem ter que mudar a coleção ou o");
            Console.WriteLine("cliente.");

            Console.Read();

            Console.Clear();

            Console.WriteLine("APLICABILIDADE");
            Console.WriteLine("\nUtilize o padrão Iterator quando sua coleção tiver uma estrutura de dados complexa por");
            Console.WriteLine("debaixo dos panos, mas você quer esconder a complexidade dela de seus clientes (seja por");
            Console.WriteLine("motivos de conveniência ou segurança).");

            Console.WriteLine("\nUtilize o padrão para reduzir a duplicação de código de travessia em sua aplicação.");

            Console.WriteLine("\nUtilize o Iterator quando você quer que seu código seja capaz de percorrer diferentes");
            Console.WriteLine("estruturas de dados ou quando os tipos dessas estruturas são desconhecidos de antemão.");

            Console.Read();

            Console.Clear();

            Console.WriteLine("PROS DO ITERATOR");

            Console.WriteLine("\nPrincípio de responsabilidade única. Você pode limpar o código cliente e as coleções ao ");
            Console.WriteLine("extrair os pesados algoritmos de travessia para classes separadas.");
            Console.ReadKey();
            Console.WriteLine("\nPrincípio aberto/fechado. Você pode implementar novos tipos de coleções e");
            Console.WriteLine("iteradores e passá-los para o código existente sem quebrar coisa alguma.");
            Console.ReadKey();
            Console.WriteLine("\nVocê pode iterar sobre a mesma coleção em paralelo porque cada objeto iterador");
            Console.WriteLine("contém seu próprio estado de iteração.");
            Console.ReadKey();
            Console.WriteLine("\nPelas mesmas razões, você pode atrasar uma iteração e continuá-la quando necessário.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("CONTRAS DO ITERATOR");

            Console.WriteLine("\nAplicar o padrão pode ser um preciosismo se sua aplicação só trabalha com coleções simples.");
            Console.ReadKey();
            Console.WriteLine("\nUsar um iterador pode ser menos eficiente que percorrer elementos de algumas coleções especializadas diretamente.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("CONSIDERAÇÕES MINHAS");
            Console.WriteLine("\nPelo que entendi sobre o iterator, serve para quando você");
            Console.WriteLine("não quer mostrar o tipo de funcionabilidade que a aplicação está rodando,");
            Console.WriteLine("Acredito que dependendo da regra de negócio, possa ser útil, mas no");
            Console.WriteLine("no momento para mim, não faz muito sentido!");
            Console.WriteLine("\nPROS: Protege e esconde o modo que se está trabalhando com coleções.");
            Console.WriteLine("CONTRA: Meio complexo");
            Console.ReadKey();
        }
    }
}
