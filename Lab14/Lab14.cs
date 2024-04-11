using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Lab14
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            Dog dog = new Dog("Собака");
            cat.ShowInfo();
            dog.ShowInfo();
        }
    }
}
