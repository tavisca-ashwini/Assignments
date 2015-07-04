using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

    public class ThreadApplication
    {
        public static int number = 0;
        public static List<int> random = new List<int>();
        public static List<int> result = new List<int>();
        public static int flag_even = 0, flag_gen = 0;
        public static PrintNum object3 = new PrintNum();
        public static int ShowThreadCount = 0;
        Thread thread3 = new Thread(new ThreadStart(object3.ShowNumber));

        public static void Main(string[] args)
        {
             GenerateNum object1 = new GenerateNum();
                EvenNum object2 = new EvenNum();

                String Str = Console.ReadLine();
                number = int.Parse(Str);

                Thread thread1 = new Thread(new ThreadStart(object1.GenerateNumber));
                Thread thread2 = new Thread(new ThreadStart(object2.EvenNumber));

                thread1.Start();
                thread2.Start();

                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object temp) { object3.ShowNumber(); }), null);
                ++ShowThreadCount;
                Monitor object_monitor = new Monitor();
                Thread thread_monitor = new Thread(new ThreadStart(object_monitor.MonitorThread));
                Console.ReadLine();
            }
        }
   