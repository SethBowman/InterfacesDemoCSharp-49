namespace InterfacesDemoCSharp_49;

public interface IAnimal
{
    //Cannot have fields in an interface

    public int Age { get; set; }
    public string Diet { get; set; }
    
    //Interface methods will ALWAYS be stubbed out methods
    //In the background Interfaces are completely abstract (even though we never use the keyword abstract)
    public void Move();
    public void Breathe();
}