using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302220108
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int increaseAmount)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh null dan maksimal 100 karakter");
            }

            if (increaseAmount > 10000000)
            {
                throw new ArgumentException("Input penambahan play count maksimal 10.000.000");
            }

            try
            {
                checked
                {
                    playCount += increaseAmount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Jumlah play count melebihi batas!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
