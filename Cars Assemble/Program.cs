using System;

class Program
{
    static void Main(string[] args)
    {
        int speed = 5;
        Console.WriteLine($"Success Rate for speed {speed}: {AssemblyLine.SuccessRate(speed)}");
        Console.WriteLine($"Production Rate per Hour for speed {speed}: {AssemblyLine.ProductionRatePerHour(speed)}");
        Console.WriteLine($"Working Items per Minute for speed {speed}: {AssemblyLine.WorkingItemsPerMinute(speed)}");
    }
}

