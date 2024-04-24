using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public void Sleep() => Console.WriteLine("Zzz");
        public abstract void Towards();
        public abstract void Eat();
    }

    public class Dog : Animal, ICanSwim
    {
        public override void Towards() => Console.WriteLine("Verso: Bau, Bau!");
        public override void Eat() => Console.WriteLine("Dieta: Mangio principalmente crocchette ci tengo alla forma fisica, Bau!");
    }

    public class Cat : Animal, ICanSwim
    {
        public override void Towards() => Console.WriteLine("Verso: Miao, Meow!");
        public override void Eat() => Console.WriteLine("Dieta: Mangio principalmente tonno al naturale ci tengo alla forma fisica, Miaeow!");
    }

    public class Moscow : Animal, ICanFly
    {
        public override void Towards() => Console.WriteLine("Verso: Butzzz!");
        public override void Eat() => Console.WriteLine("Dieta: Sorvolerei su cosa mi piace mangiare, Butzzz!");
    }

    public class Mosquito : Animal, ICanFly
    {
        public override void Towards() => Console.WriteLine("Verso: Lo conosci bene il mio verso, lo puoi sentire quando sono le 2/3 di notte");
        public override void Eat() => Console.WriteLine("Dieta: Condivido il mio nutrimento con i vampiri");
    }
}
