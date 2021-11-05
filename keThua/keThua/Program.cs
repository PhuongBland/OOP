using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keThua
{

    class Animal
    {
        protected double weight;
        protected double height;
        protected static int legs;

        protected double Weight { get => weight; set => weight = value; }
        protected double Height { get => height; set => height = value; }
        protected static int Legs { get => legs; set => legs = value; }

        public Animal()
        {

        }
        public void Info()
        {
            Console.WriteLine("Weight: " + weight + "Height: " + height + "legs" + legs);
        }
        public Animal(double w, double h, int l)
        {
            weight = w;
            height = h;
            legs = l;
        }
       
    }

    class Cat: Animal
    {
        public Cat()
        {
            Weight = 500;
            Height = 20;
            Legs = 2;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat();
            BlackCat.Info();
            Console.ReadKey();
        }
    }
}


// một đói tượng thuộc lớp cha có thể tham chiếu đén vùng 
//nhớ của đối tượng thuộc lớp con nhưng ngược lại thì không
