using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class EvenNum
    {
        public void EvenNumber()
        {
              int etemp = 0;
              while (etemp != ThreadApplication.number)
              {
                    if (ThreadApplication.random.Count() != 0)
                    {
                        if (ThreadApplication.random.ElementAt(0) % 2 == 0)
                        {
                            ThreadApplication.result.Add(ThreadApplication.random.ElementAt(0));
                        }
                        ThreadApplication.random.RemoveAt(0);
                        etemp++;
                    }
                    else
                    {
                        while (ThreadApplication.random.Count() == 0) ;
                    }
                    ThreadApplication.flag_even = 1;
                }
            }
      }
