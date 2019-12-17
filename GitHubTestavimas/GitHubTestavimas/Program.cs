using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestavimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IZinute> Zinutes = new List<IZinute>();
            Testas t = new Testas();
            Zinutes.Add(t);
            foreach (var item in Zinutes)
            {
                item.SpausdintiZinute();
            }
        }
    }
    class Testas : IZinute
    {
        public string Zinute { get; set; }

        public void SpausdintiZinute()
        {
            Console.WriteLine("zinute  su skaiciu");
        }
    }
}