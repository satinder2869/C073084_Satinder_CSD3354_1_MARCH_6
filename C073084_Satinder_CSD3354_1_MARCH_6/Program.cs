using System;
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
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate();

        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}