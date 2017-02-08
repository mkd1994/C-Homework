using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Project
{
    public static class Database
    {
        private static string filePath = "Project.txt";
        public static List<MainClass> MainList()
        {
            var list = new List<MainClass>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                var line = sr.ReadLine();

                while (line != null && line != string.Empty)
                {
                    var property = line.Split('|');

                    list.Add(new MainClass()
                        {
                            Country = property[0],
                            Capital = property[1],
                            Size = int.Parse(property[2])
                        });
                    line = sr.ReadLine();
                }

                return list;
            }
            

        }
    }
}
