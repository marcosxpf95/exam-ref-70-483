﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUseTypes.Auxiliar.Class
{
    public class MyStack <T> where T : class
    {        
        int stackTop = 0;
        T[] items = new T[100];

        public void Push(T item)
        {
            if (stackTop == items.Length)
                throw new Exception("Stack full");
            items[stackTop] = item;
            stackTop++;
        }
        public T Pop()
        {
            if (stackTop == 0)
                throw new Exception("Stack empty");
            stackTop--;
            return items[stackTop];
        }        
    }
}
