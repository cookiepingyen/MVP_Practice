using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習
{
    internal class ShowA : IShow
    {
        public void Display()
        {
            Console.WriteLine("ShowA");
        }
    }
}
