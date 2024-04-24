using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal interface ICanFly
    {
        public void ICanFly() => Console.WriteLine("Abilità: *battiti di ali* vola *battiti di ali* poi si posa");
    }
}
