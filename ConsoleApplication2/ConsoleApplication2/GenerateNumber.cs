using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class GenerateNum
{
    public void GenerateNumber()
    {
             Random r = new Random();
             for (int i = 0; i < ThreadApplication.number; i++)
             {
                    int num = r.Next(1, ThreadApplication.number);
                    ThreadApplication.random.Add(num);
                    Console.WriteLine("Generated numbers:" + num);
                }
                ThreadApplication.flag_gen = 1;
                //Console.WriteLine("stop");
            }
}
