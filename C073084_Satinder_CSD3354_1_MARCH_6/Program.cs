using System;

namespace C073084_Satinder_CSD3354_1_MARCH_6
//Satinder Pal Singh C0730484
//Sourav Mehta C0730462
//Assigmnment 2 
//March 7,2019
//Csd3354-1ssssss
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}