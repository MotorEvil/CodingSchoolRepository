using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestavimas
{
    interface IZinute
    {
         string Zinute { get; set; }
        void SpausdintiZinute();
    }
    class ZinuteKlase : IZinute
    {
        public string Zinute { get; set; }
        public void SpausdintiZinute()
        {
            Console.WriteLine("Zinute");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<IZinute> Zinutes = new List<IZinute>();
            ZinuteKlase zinute = new ZinuteKlase();
            Zinutes.Add(zinute);
            foreach (var item in Zinutes)
            {
                item.SpausdintiZinute();
            }
        }
    }
}
