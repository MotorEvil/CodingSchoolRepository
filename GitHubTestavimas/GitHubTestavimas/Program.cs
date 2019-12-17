using System;

namespace GitHubTestavimas
{
    interface IZinute
    {
        string Zinute { get; set; }
        void SpausdintiZinute();
    }

    class AsmZinute : IZinute
    {
        string Komentaras { get; set; }
        public string Zinute { get; set; }
        public void SpausdintiZinute()
        {
            Console.WriteLine("Zinute išsiųsta");
        }
    }

class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
