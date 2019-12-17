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
    class Message : IZinute
    {
        public string Zinute { get; set; }
        public Message(String zinute)
        {
            Zinute = zinute;
        }
        public void SpausdintiZinute()
        {
            Console.WriteLine(Zinute);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<IZinute> Zinutes = new List<IZinute>();
            Zinutes.Add(new Message("Works"));

            foreach(var item in Zinutes)
            {
                item.SpausdintiZinute();
            }
        }
    }
}
