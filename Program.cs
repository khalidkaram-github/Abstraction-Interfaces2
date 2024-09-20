namespace Abstraction_Interfaces2
{
    //interface with default implementation
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            //dog.MakeSound();
            dog.Move();

            var cat = new Cat();
            cat.Move();
            //cat.MakeSound();
        }
    }

    public interface IAnimal
    {
        // Method with default implementation
        void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        // Method without default implementation (abstract)
        void Move();
    }
    public class Dog : IAnimal
    {

        // Must implement the abstract method
        public void Move()
        {
            Console.WriteLine("The dog runs.");
        }
    }

    public class Cat : IAnimal
    {
        // Use the default implementation of MakeSound
        // Must implement the abstract method
        public void Move()
        {
            Console.WriteLine("The cat moves stealthily.");
        }
    }


}
