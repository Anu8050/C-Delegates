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
/*class Program
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
}*/


//using Sleep method
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");
        Thread th1 = new Thread(Method1);
        Thread th2 = new Thread(Method2);
        Thread th3 = new Thread(Method3);
        th1.Start();
        th2.Start();
        th3.Start();
        Console.WriteLine("Main Thread Ended");
        Console.Read();
    }
    static void Method1()
    {
        Console.WriteLine("Method1 - Thread1 Started");
        Thread.Sleep(3000);
        Console.WriteLine("Method1 - Thread 1 Ended");
    }
    static void Method2()
    {
        Console.WriteLine("Method2 - Thread2 Started");
        Thread.Sleep(2000);
        Console.WriteLine("Method2 - Thread2 Ended");
    }
    static void Method3()
    {
        Console.WriteLine("Method3 - Thread3 Started");
        Thread.Sleep(5000);
        Console.WriteLine("Method3 - Thread3 Ended");
    }
}*/

//Using Join Method of Thread Class
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");
        Thread th1 = new Thread(Method1);
        Thread th2 = new Thread(Method2);
        Thread th3 = new Thread(Method3);

        th1.Start();
        th2.Start();
        th3.Start();

        th1.Join();
        th2.Join();
        th3.Join();

        Console.WriteLine("Main Thread Ended");
    }

    static void Method1()
    {
        Console.WriteLine("Method1 - Thread1 Started");
        Thread.Sleep(1000);
        Console.WriteLine("Method1 - Thread 1 Ended");
    }
    static void Method2()
    {
        Console.WriteLine("Method2 - Thread2 Started");
        Thread.Sleep(2000);
        Console.WriteLine("Method2 - Thread2 Ended");
    }
    static void Method3()
    {
        Console.WriteLine("Method3 - Thread3 Started");
        Thread.Sleep(5000);
        Console.WriteLine("Method3 - Thread3 Ended");
    }
}*/


//Example without Thread Synchronization
/*class Program
{
    static void Main(string[] args)
    {
        Thread th1 = new Thread(SomeMethod)
        {
            Name = "Thread 1"
        };

        Thread th2 = new Thread(SomeMethod)
        {
            Name = "Thread 2"
        };

        Thread th3 = new Thread(SomeMethod)
        {
            Name = "Thread 3"
        };

        th1.Start();
        th2.Start();
        th3.Start();
    }

    public static void SomeMethod()
    {
        Console.Write("[Welcome to the ");
        Thread.Sleep(1000);
        Console.WriteLine("World of Dotnet!]");
    }
}*/

//Example using Thread Synchronizatio
/*class Program
{
    Static object lockObject = new object();
    static void Main(string[] args)
    {
        Thread th1 = new Thread(SomeMethod)
        {
            Name = "Thread 1"
        };

        Thread th2 = new Thread(SomeMethod)
        {
            Name = "Thread 2"
        };

        Thread th3 = new Thread(SomeMethod)
        {
            Name = "Thread 3"
        };

        th1.Start();
        th2.Start();
        th3.Start();
    }

    public static void SomeMethod()
    {
        loack (lockObject)
        {
            Console.Write("[Welcome to the ");
            Thread.Sleep(1000);
            Console.WriteLine("World of Dotnet!]");

        }
        
    }
}*/

//Real time example using thread synchronization.
/*namespace ThreadStateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookMyShow bookMyShow = new BookMyShow();
            Thread t1 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread3"
            };
            
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }

    public class BookMyShow
    {
        private object lockObject = new object();

        int AvailableTickets = 6;
        static int i = 1, j = 4, k = 3;
        public void BookTicket(string name, int wantedtickets)
        {
            lock(lockObject)
            {
                if (wantedtickets <= AvailableTickets)
                {
                    Console.WriteLine(wantedtickets + " booked to " + name);
                    AvailableTickets = AvailableTickets - wantedtickets;
                }
                else
                {
                    Console.WriteLine("No tickets Available to book");
                }
            }
        }
        public void TicketBookig()
        {
            string name = Thread.CurrentThread.Name;
            if (name.Equals("Thread1"))
            {
                BookTicket(name, i);
            }
            else if (name.Equals("Thread2"))
            {
                BookTicket(name, j);
            }
            else
            {
                BookTicket(name, k);
            }
        }
    }
}*/


//using Lock
/*class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(DisplayMessage);
        Thread t2 = new Thread(DisplayMessage);
        Thread t3 = new Thread(DisplayMessage);

        t1.Start();
        t2.Start();
        t3.Start();

        Console.Read();
    }

    private static readonly object LockDisplayMethod = new object();
    static void DisplayMessage()
    {
        lock(LockDisplayMethod)
        {
            Console.Write("[Welcome to the ");
            Thread.Sleep(1000);
            Console.WriteLine("world of dotnet!]");
        }
    }
}*/


//using  Monitor Class in C# to Protect Shared Resource from Concurrent Access
/*class Program
{
    private static readonly object lockPrintNum = new object();

    public static void PrintNum()
    {
        Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
        
        try
        {
            Monitor.Enter(lockPrintNum);
            Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        finally
        {
            Monitor.Exit(lockPrintNum);
            Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
        }
    }

    static void Main(string[] args)
    {
        Thread[] Threads = new Thread[3];
        for (int i = 0; i < 3; i++)
        {
            Threads[i] = new Thread(PrintNum)
            {
                Name = "Child Thread " + i
            };
        }

        foreach (Thread t in Threads)
        {
            t.Start();
        }
    }
}*/

//Monitor.Enter(lockObject, ref IslockTaken) Method //Monitor.Enter() method with 2 parameter.
/*class Program
{
    private static readonly object lockPrintNumberst = new object();
    public static void PrintNumbers()
    {
        Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
        bool IsLockTaken = false;
        
        try
        {
            Monitor.Enter(lockPrintNumberst, ref IsLockTaken);
            if(IsLockTaken)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
        }
        finally
        {
            if (IsLockTaken)
            {
                Monitor.Exit(lockPrintNumberst);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
            }
        }
    }
    static void Main(string[] args)
    {
        Thread[] Threads = new Thread[3];
        for (int i = 0; i < 3; i++)
        {
            Threads[i] = new Thread(PrintNumbers)
            {
                Name = "Child Thread " + i
            };
        }
        foreach (Thread t in Threads)
        {
            t.Start();
        }
        Console.ReadLine();
    }
}*/


//Using Monitor.TryEnter() method// TryEnter(Object, TimeSpan, Boolean) Method of Monitor Class.
/*class Program
{
    private static readonly object lockPrintNum = new object();
    public static void PrintNum()
    {
        TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
        bool lockTaken = false;
        try
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
            Monitor.TryEnter(lockPrintNum, timeout, ref lockTaken);
            if (lockTaken)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Lock was not acquired");
            }
        }
        finally
        {
            if (lockTaken)
            {
                Monitor.Exit(lockPrintNum);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
            }
        }
    }
    static void Main(string[] args)
    {
        Thread[] Threads = new Thread[3];
        for (int i = 0; i < 3; i++)
        {
            Threads[i] = new Thread(PrintNum)
            {
                Name = "Child Thread " + i
            };
        }
        foreach (Thread t in Threads)
        {
            t.Start();
        }
    }
}
*/

//Pulse() Methods of Monitor Class
class Program
{
    const int numberLimit = 20;

    static readonly object _lockMonitor = new object();

    static void Main(string[] args)
    {
        Thread EvenThread = new Thread(PrintEvenNumbers);
        Thread OddThread = new Thread(PrintOddNumbers);
        EvenThread.Start();
        Thread.Sleep(100);
        OddThread.Start();


        OddThread.Join();
        EvenThread.Join();

        Console.WriteLine("\nMain method completed");
        Console.ReadKey();
    }

    static void PrintEvenNumbers()
    {
        try
        {

            Monitor.Enter(_lockMonitor);
            for (int i = 0; i <= numberLimit; i = i + 2)
            {

                Console.Write($"{i} ");

                Monitor.Pulse(_lockMonitor);


                bool isLast = false;
                if (i == numberLimit)
                {
                    isLast = true;
                }

                if (!isLast)
                {

                    Monitor.Wait(_lockMonitor);
                }
            }
        }
        finally
        {

            Monitor.Exit(_lockMonitor);
        }

    }

    static void PrintOddNumbers()
    {
        try
        {
            Monitor.Enter(_lockMonitor);
            for (int i = 1; i <= numberLimit; i = i + 2)
            {

                Console.Write($"{i} ");


                Monitor.Pulse(_lockMonitor);

                bool isLast = false;
                if (i == numberLimit - 1)
                {
                    isLast = true;
                }

                if (!isLast)
                {
                    Monitor.Wait(_lockMonitor);
                }
            }
        }
        finally
        {
            Monitor.Exit(_lockMonitor);
        }
    }
}
