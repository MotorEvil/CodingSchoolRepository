using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestavimas
{
 
    public class Feature : IZinute
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



    class ZinuteKlase : IZinute
    {
        public string Zinute { get; set; }
        public void SpausdintiZinute()
        {
            Console.WriteLine("Zinute");

        }
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
        
        private static void Main(string[] args)
        {
            List<IZinute> Zinutes = new List<IZinute>();

            Zinutes.Add(new Message("Works"));



            ZinuteKlase zinute = new ZinuteKlase();
            Zinutes.Add(zinute);




            Zinutes.Add(new PagalZinute());


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

            List<IZinute> Zinutes = new List<IZinute>();
            Zinutes.Add(new ManoZinute());

            foreach(var item in Zinutes)
            {
                item.SpausdintiZinute();
            }



            Console.WriteLine("zinute  su skaiciu");



        }
    }
}