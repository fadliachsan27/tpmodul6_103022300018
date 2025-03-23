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
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Fadli Achsan Kurniawan");
            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();
        }
    }
}
