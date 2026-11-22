using System;

SimpleGoal testGoal = new SimpleGoal(
    "Finish Homework",
    "Complete CSE 210 assignment",
    500
);

Console.WriteLine(testGoal.RecordEvent());
Console.WriteLine(testGoal.RecordEvent());