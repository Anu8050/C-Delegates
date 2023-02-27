// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Threading;
/*namespace DelegatesDemo
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = 
                        new WorkPerformedHandler(Manager_WorkPerformed);
            del1(10, WorkType.Golf);
            //del1.Invoke(50, WorkType.GotoMeetings);
            Console.ReadKey();
        }
        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work Performed by Event Handler");
            Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
        }
    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}*/

//Understanding  delegates examples
/*public class AnonymousMethods
{
    public delegate string GreetingDelegates(string name);

    public static string Greeting(string name)
    {
        return "hi" + name;
    }

    static void Main(string[] args)
    {
        GreetingDelegates gd = new GreetingDelegates(Greeting);
        string greetingmsg = gd.Invoke("anu");
        Console.WriteLine(greetingmsg);
    }
}*/

//Understand Anonymous Methods
/*class AnonymousMethods
{
    public delegate string GreetingDelegates(string name);

    static void Main(string[] args)
    {

        GreetingDelegates gd = delegate (string name)
        {
            return "hi " + name;
        };

        string greetingmsg = gd.Invoke("anu");
        Console.WriteLine(greetingmsg);

    }
}*/

//Func delegate
/*class FuncDelegate
{
    static int sum(int x, int y)
    {
        return x+y;
    }

    static void Main (string[] args)
    {
        Func<int, int, int> add = sum;
        int result = add(10,20);
        Console.WriteLine(result);
    }
}*/


//Action Delegate
/*class ActionDelegate
{
    static void print(int i)
    {
        Console.WriteLine(i);
    }

    static void Main(string[] args)
    {
        Action<int> prn = print;
        prn(10);
    }
}*/


//Predicate delegate
/*class Predicatedelegates
{
    static bool IsUpperCase(string str)
    {
        return str.Equals(str.ToUpper());
    }

    static void Main(string[] args)
    {
        /*Predicate<string> isUpper = IsUpperCase;

        bool result = isUpper("hello world!!");*/

        /*Predicate<string> isUpper = s => s.Equals(s.ToUpper());
        bool result = isUpper("HELLO!!");

        Predicate<string> isUpper = delegate(string s) { return s.Equals(s.ToUpper());};
        bool result = isUpper("hello world!!");

        Console.WriteLine(result);
    }
}*/


//LambdaExpression
/*class LambdaExpression
{
    public delegate string GreetingDelegates(string name);

    static void Main(string[] args)
    {

        GreetingDelegates gd = (name) =>
        {
            return "hi " + name;
        };

        string greetingmsg = gd.Invoke("anu");
        Console.WriteLine(greetingmsg);

    }
}*/


//Thread
/*class Program 
{
    static void Main(String[] args)
    {
        Thread t = Thread.CurrentThread;
        t.Name = "Main Thread";
        Console.WriteLine("Current Executing Thread Name :" + t.Name);
        Console.WriteLine("Current Executing Thread Name :" + Thread.CurrentThread.Name);
    }
}*/


//Multithreading
/*using System.Threading;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
        static void Method1()
        {
            Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
            Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
            Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
        }
        static void Method3()
        {
            Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
            Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
        }
    }
}*/


//Constructors of Thread Class
/*class ThreadConstructor
{
    static void Main(String[] args)
    {
        Thread th = new Thread(Displaynum);
        th.Start();
    }
    static void Displaynum()
    {
        for(int i=0; i<=5; i++)
        {
            Console.WriteLine("Method1:" + i);
        }
    }
}*/

//Creating Thread Class Instance using Lambda Expression
/*class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        });
        t1.Start();
    }
}*/

//Thread Function with Parameter
class Program
{
    static void Main(string[] args)
    {
        Program obj = new Program();
        Thread t1 = new Thread(obj.DisplayNumbers);
        t1.Start(5);
        Console.Read();
    }
    public void DisplayNumbers(object Max)
    {
        int Num = Convert.ToInt32(Max);
        for (int i = 1; i <= Num; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
    }
}

