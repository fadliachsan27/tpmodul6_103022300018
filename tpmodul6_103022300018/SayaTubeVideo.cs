using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, 
                "Judul tidak boleh null atau lebih dari 100 karakter.");
            
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null atau lebih dari 100 karakter.");
            }
            this.title = title;
            this.playCount = 0;
            this.id = new Random().Next(10000, 99999); // Generate ID 5 digit
        }

        // Method untuk menambahkan playCount dengan Design by Contract
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0 && count <= 10000000, "Jumlah play count harus antara 1 dan 10.000.000.");

            if (count < 0 || count > 10000000)
            {
                throw new ArgumentException("Jumlah play count harus antara 1 dan 10.000.000.");
            }

            if (this.playCount > int.MaxValue - count)
            {
                Console.WriteLine("Play count sudah mencapai batas maksimum.");
                return; // Langsung keluar tanpa menampilkan error berulang kali
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
