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


            Zinutes.Add(new PagalZinute());

            foreach (var item in Zinutes)
            {
                item.SpausdintiZinute();
            }
        }
    }
}