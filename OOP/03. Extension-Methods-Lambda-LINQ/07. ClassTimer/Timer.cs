using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ClassTimer
{
    class Timer
    {
        public void Start(ClassTimer.SimpleDelegate d, int t)
        {
            Thread anotherThread = new Thread(delegate()
                {
                    while (true)
                    {
                        d();
                        Thread.Sleep(t * 1000);
                    }
                });

            anotherThread.Start();
        }
    }
}
