using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Dog
    {    //states
        private string hairLength;
        private int height;
        private int runningSpeed;
        double weight;

        //behaviors

        public Dog()
        {

        }

        public Dog(string a, int b, int c, double d)
        {
            this.hairLength = a;
            this.height = b;
            this.runningSpeed = c;
            this.weight = d;


        }

        public void Run()
        {
            Console.WriteLine("The dog runs at a speed of " + runningSpeed);
        }

        public void Barks()
        {
            Console.WriteLine("The dog " + weight);
        }

        public void Potty()
        {
            Console.WriteLine("The dog crap its self at a running pace of " + runningSpeed);
        }
        public void Cuddle()
        {
            Console.WriteLine("The dog likes to cuddle on top of me while I sleep, but he is " + weight + " lbs ");
        }

    }
}
