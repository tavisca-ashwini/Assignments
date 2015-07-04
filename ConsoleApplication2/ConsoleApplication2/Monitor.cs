using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

    public class Monitor
    {
        public void MonitorThread()
        {
            int ThreadCount = 0, EvenNum = 0;
            while (true)
            {
                EvenNum = ThreadApplication.result.Count();
                ThreadCount = ThreadApplication.ShowThreadCount;

                int Num_Thread = EvenNum / ThreadCount;

                if (Num_Thread < 5)
                {
                    Console.WriteLine("Thread_ID : {0}", System.Threading.Thread.CurrentThread.ManagedThreadId + "Stopped");
                    Thread.CurrentThread.Abort();
                    ThreadApplication.ShowThreadCount--;
                }
                else if (Num_Thread >= 5)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object temp) { ThreadApplication.object3.ShowNumber(); }), null);
                    ThreadApplication.ShowThreadCount++;
                }
            }
        }
    }

