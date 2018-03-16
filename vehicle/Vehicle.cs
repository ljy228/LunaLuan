using System;



public class Vehicle
{
    public string Vehicle_cate { get; set; }

    public string licence { get; set; }
    public int engine_power { get; set; }
    public string type { get; set; }

    public static void Print(string info)
    {
        Console.WriteLine(info);
    }

}
