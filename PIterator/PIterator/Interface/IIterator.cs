using PIterator.Class;


namespace PIterator.Interface
{
    public interface IIterator
    {
        //Métodos e Prop obrigatórios
        Cliente First();
        Cliente Next();
        bool IsDone { get; }
    }
}
