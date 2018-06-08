using SpiralCoder.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SpiralCoder
{
    class Poo
    {
        public static void Get()
        {
            object[] PooArray = new object[]
            {
                Resources.poo01,
                Resources.poo02,
                Resources.poo03,
                Resources.poo04,
                Resources.poo05,
                Resources.poo06
            };

            Random random = new Random();

            SoundPlayer soundPlayer = new SoundPlayer((Stream)PooArray[random.Next(6)]);
            soundPlayer.Load();
            soundPlayer.Play();
        }
    }
}
