namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 1
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Moscow());
            animals.Add(new Mosquito());
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                animal.Towards();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                animal.Eat();
            }

            // ESERCIZIO 2
            List<ICanFly> flyers = new List<ICanFly>();
            flyers.Add(new Moscow());
            flyers.Add(new Mosquito());
            
            foreach (var flyer in flyers)
            {
                Console.WriteLine(flyer.GetType().Name);
                flyer.ICanFly();
            }

            List<ICanSwim> swimmers = new List<ICanSwim>();
            swimmers.Add(new Dog());
            swimmers.Add(new Cat());

            foreach (var swimmer in swimmers)
            {
                Console.WriteLine(swimmer.GetType().Name);
                swimmer.ICanSwim();
            }

        }
    }
}
