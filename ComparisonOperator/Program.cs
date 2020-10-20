using System;

namespace ComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myCow = new cow();
            Animal myCat = new cat();
            Animal myDog = new dog();
            myAnimal.animalSound();
            myCow.animalSound();
            myCat.animalSound();
            myDog.animalSound();

        }

    }
    //parent class make sure to put virtual so that it can be overriden by child classes
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("the animals make sounds like:");
        }
    }
    //start of child classes tat 'extend' the parent Animal class and its properties
    class cow: Animal
    {
        public override  void animalSound()
        {
            Console.WriteLine("cows go MOOOOOO");
        }
    }
    class cat: Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("cats go Meow");
        }
    }
    class dog: Animal
    {
        public override void animalSound()
        {
            {
                Console.WriteLine("dogs go woof");
            }
        }
    }
}
