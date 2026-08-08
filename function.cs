using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>();

        students.Add("Revathi");
        students.Add("Priya");
        students.Add("Arun");

        Console.WriteLine("List:");
        Console.WriteLine(students[2]);

        Dictionary<int, string> studentDetails =
            new Dictionary<int, string>();

        studentDetails.Add(101, "Revathi");
        studentDetails.Add(102, "Priya");

        Console.WriteLine("Dictionary:");
        Console.WriteLine(studentDetails[102]);


        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Revathi");
        queue.Enqueue("Priya");
        queue.Enqueue("Arun");

        Console.WriteLine("Queue:");
        Console.WriteLine(queue.Dequeue());


        Stack<string> stack = new Stack<string>();

        stack.Push("Book 1");
        stack.Push("Book 2");
        stack.Push("Book 3");

        Console.WriteLine("Stack:");
        Console.WriteLine(stack.Pop());


        HashSet<string> names = new HashSet<string>();

        names.Add("Revathi");
        names.Add("Priya");
        names.Add("Revathi");
        names.Add("Reva");

        Console.WriteLine("HashSet Count:");
        Console.WriteLine(names.Count);
    }
}
