using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{

    interface ISpeak
    {

        void Speak();
    }

    class Animal : ISpeak
    {
        public void Speak() {
            Console.WriteLine("Animal is speaking...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ISpeak animal = new Animal();
            animal.Speak();
            Console.ReadKey();
        }
    }
}


/* interface là 1 tập các thành phần chỉ có khai báo mà 
//không có phần định nghĩa giống phương thức thuần ảo
 các thành phần: phương thức, property, event, indexers
Các thành phần mặc định public
Để tránh nhầm lẫn thường thêm chữ "I" phía trước tên
*/