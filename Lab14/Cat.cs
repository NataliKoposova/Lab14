using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Cat : Animal
    {
        
        private string name;
        public Cat(string name) : base(name)
        {
            this.name = name;
        }

        public override string Name 
        {
            get => name; 
            set => name = value;
        }        
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
