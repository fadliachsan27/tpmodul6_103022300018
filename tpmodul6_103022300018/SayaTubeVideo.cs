using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300018
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        // Konstruktor
        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null atau lebih dari 100 karakter.");
            }
            this.title = title;
            this.playCount = 0;
            this.id = new Random().Next(10000, 99999); // Generate ID 5 digit
        }

        // Method untuk menambahkan playCount
        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentException("Jumlah play count harus antara 0 dan 10.000.000.");
            }
            if (this.playCount + count < 0) // Antisipasi overflow
            {
                throw new OverflowException("Play count melebihi batas maksimum.");
            }
            this.playCount += count;
        }

        // Method untuk mencetak detail video
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
