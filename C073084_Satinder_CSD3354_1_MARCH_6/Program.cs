﻿using System;
//Satinder Pal Singh C0730484
//Sourav Mehta C0730462
//Assigmnment 2 
//March 7,2019

namespace C073084_Satinder_CSD3354_1_MARCH_6

{

    public class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        int Method1(int intMethod1)
        {
            return intMethod1 * 4;
        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)
        {
            for (int i = 1; i <= 5; i++)
                System.Console.Write(myDelegate(i) + " ");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}