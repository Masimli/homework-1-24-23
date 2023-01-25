namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal();
            animal1.age = 1;
            animal1.breed = "dog";
            animal1.name = "Jake";
            animal1.color = "white";
            Console.WriteLine(animal1.GetDetails());

            var animal2 = new Animal();
            animal2.age = 3;
            animal2.breed = "cat";
            animal2.name = "Tom";
            animal2.color = "black";
            Console.WriteLine(animal2.GetDetails());
        }
    }
}