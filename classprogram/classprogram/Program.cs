using System;

namespace classprogram
{

    class Animal
    {
        public double Weight;
        public double Height;

        public void Info()
        {
            // Các phương thức bên trong lớp có thể gọi đến các thành phần khác( bao gồm thuộc tính và pthuc) trong lớp đó.

            Console.WriteLine("Height: " + Height + " Weight: " + Weight);
        }
    }

    class Cat
    {
        public double Weight;
        public double Height;

        // constructor không có tham số
        public Cat()
        {
            Weight = 800;
            Height = 10;
        }

        // constructor có tham số
        public Cat(int w, int h)
        {
            Weight = w;
            Height = h;
        }
        ~ Cat()
        {
            Console.WriteLine("Hủy");
        }
        public void Info()
        {
            // Các phương thức bên trong lớp có thể gọi đến các thành phần khác( bao gồm thuộc tính và pthuc) trong lớp đó.

            Console.WriteLine("Height: " + Height + " Weight: " + Weight);
        }
    }
    class Program
    {
        public static object BackCat { get; private set; }

        static void Main(string[] args)
        {
            //phương thức khởi tạo
            Animal Dog = new Animal();
            Dog.Weight = 2;
            Dog.Height = 5;

            Dog.Info(); // gọi phương thức của đối tượng

            Cat BlackCat = new Cat();

            BlackCat.Info(); // gọi phương thức của đối tượng

            Cat WhiteCat = new Cat(10, 20);

            WhiteCat.Info();


           BlackCat = new Cat();


            Console.ReadKey();
        }
    }
}


//==================== Struct ==========================

/*kiểu tham trị
không có destructor
không thể khai báo phwuong thức khởi tạo mặc dịnh (không đối số)
-không có khả năng kế thừa

//======================== Class ====================

Kiểu tham chiếu
Có destructor
Có thể khai báo phwuong thức khởi tạo mặc dịnh (không đối số)
Có khả năng kế thừa
*/