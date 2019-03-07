using System;

namespace C073084_Satinder_CSD3354_1_MARCH_6
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Methodl()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Methodl);
            myDelegate();
        }
    }
}
