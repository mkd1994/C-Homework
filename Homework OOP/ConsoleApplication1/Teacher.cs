using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Teacher : Person
    {
        public string teaching { get; set; }

        public Teacher()
        {
            name = this.name;
            surname = this.surname;
            age = this.age;
            experience = this.experience;
            teaching = this.teaching;
        }

        public Teacher(string a, string b)
        {
            name = a;
            surname = b;
            teaching = this.teaching;
        }

        public abstract void checkhomework()
        {}

        protected void greet()
        {
            Console.WriteLine("Hello");
        }

        private void morning()
        {
            Console.WriteLine("Good morning");
        }

        private void goodbye()
        {
            Console.WriteLine("Goodbye");
        }

    }
}
