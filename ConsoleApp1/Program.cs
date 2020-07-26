using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string w = p.GetString();
            Console.WriteLine(w);
        }

        public  string GetString()
        {
            return DateTime.Now.ToString();
        }
    }
}
