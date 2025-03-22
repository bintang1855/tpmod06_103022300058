using System;
using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace tpmodul6_103022300058
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null.");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;

            Contract.Invariant(this.playCount >= 0, "Invariant Error: playCount tidak boleh negatif.");
            Debug.Assert(this.playCount >= 0, "Debug.Assert: playCount tidak boleh negatif.");
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count >= 0 && count <= 10000000, "Penambahan play count tidak boleh negatif dan tidak melebihi 10.000.000");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Judul: " + this.title);
            Console.WriteLine("ID Video: " + this.id);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
