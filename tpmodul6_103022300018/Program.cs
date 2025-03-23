using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300018
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo
                ("Tutorial Design By Contract - Muhammad Fadli Achsan Kurniawan");
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    video.IncreasePlayCount(10000000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }

            video.PrintVideoDetails();
        }
    }
}
