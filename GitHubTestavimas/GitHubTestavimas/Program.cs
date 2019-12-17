using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestavimas
{
 
    public class Feature : IZinute
    {
        public string Zinute { get; set; }
        public void SpausdintiZinute()
        {

        }
    }
    
    class Program
    {
        
        private static void Main(string[] args)
        {
            List<IZinute> Zinutes = new List<IZinute>();

            foreach (var item in Zinutes)
            {
                item.SpausdintiZinute();
            }

        }
    }
}