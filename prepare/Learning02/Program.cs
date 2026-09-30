using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("program launched");

        Job Job1 = new Job();

        Job1._company = "Microshaft";
        Job1._jobTitle = "Software Engineer";
        Job1._startYear = 2019;
        Job1._endYear = 2022;

        Console.WriteLine(Job1._company);

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Console.WriteLine(job2._company);
    }
}