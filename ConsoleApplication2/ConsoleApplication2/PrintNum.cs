using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class PrintNum
{
    public void ShowNumber()
    {
        while (true)
        {
            lock (this)
            {
                if (ThreadApplication.result.Count() != 0)
                {
                    Console.WriteLine(ThreadApplication.result.ElementAt(0));
                    Console.WriteLine("Thread_ID :{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
                    ThreadApplication.result.RemoveAt(0);
                }
                else
                {
                    if (ThreadApplication.result.Count() == 0)
                    {
                        if (ThreadApplication.flag_gen == 1 && ThreadApplication.flag_even == 1)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}