using System;
using System.Threading;

namespace UF678_M2
{
    class Milstone3
    {
        public void Inicio()
        {
            int hour = 23, minutes = 59, seconds = 58;
            bool stop = false;
            while (!stop)
            {
                seconds += 1;

                if (seconds > 59)
                {
                    minutes += 1;
                    seconds = 0;
                }
                if(minutes > 59)
                {
                    hour += 1;
                    minutes = 0;
                }
                if (hour > 23)
                {
                    hour = 0;
                }

                Console.WriteLine(string.Format("{0:00}:{1:00}:{2:00}", hour, minutes, seconds));

                Thread.Sleep(1000);
            }
        }
    }
}
