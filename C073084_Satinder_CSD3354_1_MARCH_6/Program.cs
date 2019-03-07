using System;

namespace C073084_Satinder_CSD3354_1_MARCH_6
//Satinder Pal Singh C0730484
//Sourav Mehta C0730462
//Assigmnment 2 
//March 7,2019
//Csd3354-1
{
    public class Program
    {
        public delegate void MyDelegate();

        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
        static void Main(string[] args)
        {

        }
    }
}