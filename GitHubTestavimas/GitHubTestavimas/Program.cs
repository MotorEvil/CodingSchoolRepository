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

    public class Feature : IZinute
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
            List<IZinute> Zinute = new List<IZinute>();
        }
    }
}
