using System;
using Microsoft.VisualBasic;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"The {Year} {Make} {Model} has an engine that sounds like {EngineNoise}!");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"The {Year} {Make} {Model} has a horn that sounds like {HonkNoise}!");
    }

    public Car()
    {
        
    }

    public Car(int year, string make, string model, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        IsDriveable = isDriveable;
    }
}