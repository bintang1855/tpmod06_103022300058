using tpmodul6_103022300058;


class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Bintang Anugrah Pratama");
        video.IncreasePlayCount(10000000);
        video.PrintVideoDetails();

        for (int i = 0; i < 215; i++)
        {
            video.IncreasePlayCount(10000000); 
        }
        video.PrintVideoDetails();

        Console.WriteLine();
        Console.WriteLine("test prekonsidi");
        video.IncreasePlayCount(100000000);
    }
}

