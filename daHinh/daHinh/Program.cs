using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daHinh
{

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaking......");
        }
    }

    class Cat: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat speaking......");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog speaking......");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal Cat = new Cat();
            Animal Dog = new Dog();
            Cat.Speak();
            Dog.Speak();
            Console.ReadKey();

        }
    }
}

/* từ khóa virtual và override
 * phương thức thuần ảo là phương thức ảo và không có định nghĩa bên trong
 * virtual là phương thúc ảo có thể ghi đề được
 * override dùng để dánh dấu phuc ghi đè lên phương thức của lớp cha
 * abstract: dùng khai báo 1 lớp trừ tượng hoặc 1 phương thức thuần ảo
 * Tính đa hình chỉ được thể hiện khi đã ghi đè lên phương thức của lớp cha
 * lớp trừu tượng là lớp chứa phương thức thuần ảo
 */ 
 
