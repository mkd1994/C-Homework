using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class MainClass
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}",this.Country,this.Capital,this.Size);
        }

    }
}
