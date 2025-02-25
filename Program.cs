using System;
using System.Collections.Generic;
using ConsoleApp19;

public class Program
{
    public static void Main()
    {
        University university = new University();

        university.AddStudent(new Student("Jivko", 90));
        university.AddStudent(new Student("Dancho", 95));
        university.AddStudent(new Student("Maksut", 85));
        university.AddStudent(new Student("Todorut", 92));

        Console.WriteLine(university.FindStudentByScore(92)); 
        Console.WriteLine(university.FindStudentByScore(95)); 
    }
}



