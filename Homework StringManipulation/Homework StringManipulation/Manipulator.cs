using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_StringManipulation
{
    public class Manipulator
    {
        public void Reverse(string a)
        {
            char[] cArray = a.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);
        }

        public void WordToUpper(string a, string b)
        {
            Console.WriteLine(b.Replace(a, a.ToUpper()));
        }

        public int WordCount(string a, string b)
        {
           var c = b.Replace(a,"");
           var d = (b.Length - c.Length) / a.Length;
           return d;
        }

        public void CopyReturn(string a, string b)
        {
            var c = b.Split('.');
            string e = "";

            for (int i = 0; i < c.Length; i++)
            {
                var d = c[i];

                if (d.Contains(a))
                {
                    e = String.Concat(e, d);
                }
            }
            Console.WriteLine("Your word is: {0}", a);
            Console.WriteLine("And its found in these sentences: {0}", e);
        }

        public void RemovePunctioation()
        {
            using (StreamReader sr = new StreamReader("String.txt"))
            {
                var line = sr.ReadLine();

                while (line != null || line != string.Empty)
                {
                    using (StreamWriter sw = new StreamWriter("StringNew.txt", true))
                    {
                        var newline = String.Empty;
                        if (line.Contains("\\p{Punct}"))
                        {
                            newline = line.Replace("\\p{Punct}", "");
                        }

                        sw.WriteLine(newline);
                    }
                    line = sr.ReadLine();
                }
            }
        }

        public void EvenText()
        {
            using (StreamReader sr = new StreamReader("String.txt"))
            {
                int linecount = 0;
                var line = sr.ReadLine();

                while (line != null || line != string.Empty)
                {
                    if (linecount % 2 == 0)
                    {
                        using (StreamWriter sw = new StreamWriter("EvenRow.txt", true))
                        {
                            sw.WriteLine(line);
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter("OddRow.txt", true))
                        {
                            sw.WriteLine(line);
                        }
                    }
                    line = sr.ReadLine();
                    linecount++;
                }
            }
        }
    }
}
