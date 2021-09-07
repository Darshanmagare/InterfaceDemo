using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

public interface WildAnimal
{
    void taste();   
}

public interface PetAnimal
{
    void Color();
}

public class InterfaceImplementation : WildAnimal,PetAnimal
{
    public void taste()
    {
        Console.WriteLine("Sensing different tastes");

    }
    public void Color()
    {
        Console.WriteLine("Colorful");

    }



    abstract class interfaceAbstractimp :PetAnimal,WildAnimal
    {
        public void Color()
        {
            Console.WriteLine("Colorful");

        }

    }
}