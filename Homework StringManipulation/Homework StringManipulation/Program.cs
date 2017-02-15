using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Manipulator man = new Manipulator();
            string b = "home";
            string a = "home is the best place to realx. Your home is the best place to have a party, nothing can replace home.";
            string c = "I am coming home for tonight. I like to watch tv. There are over 1000 gods in the world. But i am the god at home. Dont doubt my home manners";
            man.Reverse("desereveR");

            man.WordToUpper("home",a);

            man.WordCount(b, a);

            man.CopyReturn(b, c);

            ////man.RemovePunctioation(); BROKEN PLEASE FIX?

            man.EvenText();
        }
    }
}
