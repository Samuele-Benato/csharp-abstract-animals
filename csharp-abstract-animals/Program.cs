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
                animal.Towards();
            }
            foreach (var animal in animals)
            {
                animal.Eat();
            }

            /*
            
                **Esercizio 2 : interfacce**
                Alcuni degli animali che abbiamo creato volano, altri nuotano.
                Gli animali che volano hanno il seguente metodo :
                - void Vola() (mostra a video “Sto volando!!!”)
                Gli animali che nuotano hanno il seguente metodo :
                - void Nuota() (mostra a video “Sto nuotando!!!”)
                Scrivere un programma avente 2 metodi :
                - void FaiVolare(IVolante animale)
                - void FaiNuotare(INuotante animale)
                Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
                Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.
                Buon lavoro! :)
            */
        }
    }
}
