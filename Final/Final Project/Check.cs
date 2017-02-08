using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Project
{
    public class Check
    {
        public void FirstCheck(string a)
        {
            using (StreamReader sr = new StreamReader("Project.txt"))
            {
                var line = sr.ReadLine();

                while (line != null && line != string.Empty)
                {
                    if (line == a)
                    {
                        Console.WriteLine("A country with that name exists in the database");
                    }
                    line = sr.ReadLine();
                }
            }
        }
    }
}
