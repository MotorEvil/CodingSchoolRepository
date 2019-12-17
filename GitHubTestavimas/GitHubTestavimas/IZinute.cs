namespace GitHubTestavimas
{
    interface IZinute
    {
        string Zinute { get; set; }

        void SpausdintiZinute();
    }
    class PagalZinute: IZinute
    { 
        public string Zinute { get; set; }
        public void SpausdintiZinute()
        { 
         
        }

    }
}