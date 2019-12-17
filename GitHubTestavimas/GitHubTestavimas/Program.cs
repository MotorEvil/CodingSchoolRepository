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
    internal class ManoZinute : IZinute
    {
        public string Zinute { get; set; }
        public void SpausdintiZinute()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IZinute> Zinutes = new List<IZinute>();
            Zinutes.Add(new ManoZinute());
            foreach(var item in Zinutes)
            {
                item.SpausdintiZinute();
            }
        }
    }
}
