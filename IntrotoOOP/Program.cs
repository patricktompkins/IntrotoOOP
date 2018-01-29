using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr.Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();

            secondCat.Meow();

            Dog dog1 = new Dog("short", 10, 49, 100.55);

            dog1.Run();
            dog1.Barks();
            dog1.Potty();
            dog1.Cuddle();
        }
    }
}
;