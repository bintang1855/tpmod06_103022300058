using tpmodul6_103022300058;


class Program 
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Bintang Anugrah Pratama");
        video.IncreasePlayCount(18052005);
        video.PrintVideoDetails();
    }
}

