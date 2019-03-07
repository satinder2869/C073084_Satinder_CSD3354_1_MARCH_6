using System;
//Satinder Pal Singh C0730484
//Sourav Mehta C0730462
//Assigmnment 2 
//March 7,2019

namespace C073084_Satinder_CSD3354_1_MARCH_6
{ 
    public class Program
{
    public static void Main()
    {
        DelegateExercises delegateExercises = new DelegateExercises();
        delegateExercises.Method3();
        Console.ReadLine();
    }
}

public delegate void MyDelegate();

public class DelegateExercises
{
    void Method1()
    {
        System.Console.WriteLine("Method1");


    }

    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
        System.Console.WriteLine(myDelegate.ToString());
    }
}
}