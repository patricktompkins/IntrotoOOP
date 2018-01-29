using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Cat
    {
        //STATES
          //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;



        //Properties
        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }


    
        // BEHAVIORS
        //Constructors
        public Cat()
        {
            //default constructor 
            //- doesnt take parameters ( nothing in the paraentheses)
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;

        }

        //methods
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;

            }

            Console.WriteLine("Is the cat hungary? " + isHungry);
        }

            public void Meow()
            {
                Console.WriteLine("\a");
            }

           



        
    }
}
