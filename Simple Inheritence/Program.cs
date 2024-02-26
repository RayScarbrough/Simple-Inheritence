using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
            Console.WriteLine();
        }

    }

    // derived class of Animal 
    class Cat : Animal
    {
        public string color;
        public int age;
        public double weight;

        public Cat()

            : base()
        {
            age = 0;
            weight = 0;
            color = "";
        }

        public Cat(string name, string color, int age, double weight)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }
        public void displayCat()
        {

            Console.WriteLine($"Cat information\nname: {name}\nColor: {color}\nWeight: {weight}\nAge: {age}");
        }

    }
    class Monkey : Animal
    {
        public string species;
        public int age;
        public double weight;

        public Monkey()

            : base()
        {
            age = 0;
            weight = 0;
            species = "";
        }

        public Monkey(string name, string species, int age, double weight)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.species = species;
        }
        public void displayMonkey()
        {

            Console.WriteLine($"Monkey information\nname: {name}\nSpecies: {species}\nWeight: {weight}\nAge: {age}");
        }


        class Program
        {
            static void Main(string[] args)
            {
                // object of base class
                Animal myPet = new Animal();
                myPet.name = "Sparky";
                myPet.display();

                // derived class object using default constructor
                Cat Scooby = new Cat(); ;
                Scooby.name = "Scooby";
                Scooby.color = "black and white";
                Scooby.age = 13;
                Scooby.weight = 20;



                //derived class object using parameterized constructor 
                Cat Wisp = new Cat("Wisp", "white", 1, 5);



                //dislay cats info
                Scooby.displayCat();
                Console.WriteLine();
                Wisp.displayCat();
                Console.WriteLine();




                // derived class object using default constructor Monkey
                Monkey Coco = new Monkey(); ;
                Coco.name = "Coco";
                Coco.species = "Spider Monkey";
                Coco.age = 15;
                Coco.weight = 24;



                //derived class object using parameterized constructor Monkey
                Monkey George = new Monkey("George", "Pygmy Marmoset", 1, .5);



                //dislay Monkey info
                Coco.displayMonkey();
                Console.WriteLine();
                George.displayMonkey();


                Console.ReadLine();


            }

        }

    }
}