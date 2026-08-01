using System;

class conditional_stat
{
    static void Main()
    {
        try
        {
            // Array
            int[] marks = { 80, 90, 75, 85 };

            Console.WriteLine("Student Marks:");

            // Loop
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }

            // Method call
            int total = CalculateTotal(marks);

            Console.WriteLine("Total Mark: " + total);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Program Completed");
        }
    }


    // Method
    static int CalculateTotal(int[] marks)
    {
        int sum = 0;

        // Loop inside Method
        foreach (int mark in marks)
        {
            sum = sum + mark;
        }

        return sum;
    }
}
