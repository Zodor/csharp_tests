using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp1
{
    public interface Mammal
    {
        int getLegs();
        void setAge(int age);
        int getAge();
        string makeSound();
        void setSound(string sound);
    }

    public abstract class Animal : Mammal
    {
        private int legs;

        public int Legs
        {
            get
            {
                return legs;
            }
            set
            {
                legs = value;
            }
        }

        public int Age { get; set; }
        public string Sound { get; set; }

        public int getAge()
        {
            return Age;
        }

        public void setAge(int age)
        {
            this.Age = age;
        }

        public int getLegs()
        {
            return Legs;
        }

        public string makeSound()
        {
            return Sound;
        }

        public void setSound(string sound)
        {
            Sound = sound;
        }
    }

    public abstract class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
            setSound("Morr Morr");
        }
    }

    public abstract class Spider : Animal
    {
        public Spider()
        {
            Legs = 8;
            setSound("Shhhhh");
        }
    }

    public class GoldenRetriever : Dog
    {
        public string Color { get; set; }

        public GoldenRetriever()
        {
            setAge(0);
            Color = "Yellow";
        }

        public GoldenRetriever(int age)
        {
            setAge(age);
            Color = "Yellow";
        }
    }

    public class BlackWidow<T> : Spider
    {
        public string Color { get; set; }
        public T Name { get; set; }

        public T getName()
        {
            return this.Name;
        }
        void setName(T name)
        {
            this.Name = name;
        }

        public BlackWidow()
        {
            setAge(0);
            Color = "Silver";
        }

        public BlackWidow(string sound, T name)
        {
            setAge(0);
            setSound(sound);
            Color = "Silver";
            Name = name;
        }

        public BlackWidow(int age, T name)
        {
            setAge(age);
            Color = "Silver";
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GoldenRetriever dog1 = new GoldenRetriever(5);
            BlackWidow<string> spider1 = new BlackWidow<string>("Grrrr", "Olle");
            BlackWidow<int> spider2 = new BlackWidow<int>(10, 5);

            Console.WriteLine("Golden Retriever ({4}) who is a Dog says: {0} and is {1} years old and has the color of {2} with {3} legs.", dog1.makeSound(), dog1.getAge(), dog1.Color, dog1.getLegs(), "n/a");
            Console.WriteLine("BlackWidow ({4}) who is a Spider says: {0} and is {1} years old and has the color of {2} with {3} legs.", spider1.makeSound(), spider1.getAge(), spider1.Color, spider1.getLegs(), spider1.getName());
            Console.WriteLine("BlackWidow ({4}) who is a Spider says: {0} and is {1} years old and has the color of {2} with {3} legs.", spider2.makeSound(), spider2.getAge(), spider2.Color, spider2.getLegs(), spider2.Name);
            Console.ReadLine();
        }
    }
}
