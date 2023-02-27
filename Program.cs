// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
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



