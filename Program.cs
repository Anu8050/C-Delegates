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


public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Predicate<Employee> employeePredicate = 
        new Predicate<Employee>(IsEmployeeExist);

        List<Employee> listEmployee = new List<Employee>()
        {
            new Employee { ID = 101, Name = "Ramu", Gender = "Male", Salary = 100000},
            new Employee { ID = 102, Name = "Anusha", Gender ="Female", Salary =1000},
            new EMployee {ID = 103, Name = "anu", Gender ="Female", Salary =20000 },
        };

        Employee employee = listEmployees.Find(x => employeePredicate(x));
        Console.WriteLine(@"ID : {0} , Name : {1}, Gender : {2}, Salary : {3}", 
        employee.ID, employee.Name, employee.Gender, employee.Salary);
    }

    public static bool IsEmployeeExist(Employee Emp)
    { 
        return Emp.ID ==103;
    }
}


