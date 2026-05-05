public class Temperature
{
    public const double ROOM_TEMP_LOWER_C = 20.0;
    public const double ROOM_TEMP_UPPER_C = 23.0;
    public Temperature(double t)
    {
        Temp = t;
    }

    public static double FtoC(double FTemp)
    {
        double CTemp = (FTemp - 32.0) * (5.0 / 9.0);
        return CTemp;
    }
    public static double CtoF(double CTemp)
    {
        double FTemp = (CTemp * (9.0/5.0)) + 32.0;
        return FTemp;
    }

    public double Temp { get; set; }

    public bool IsRoomTemp()
    {
        return Temp >= ROOM_TEMP_LOWER_C && Temp <= ROOM_TEMP_UPPER_C;
    }

    // Override isRoomTemp and add a static version of it
    public static bool IsRoomTemp(double temp)
    {
        return temp >= ROOM_TEMP_LOWER_C && temp <= ROOM_TEMP_UPPER_C;
    }


    //This will result in error
    //public bool IsRoomTemp
    //{
    //    get => Temp >= ROOM_TEMP_LOWER_C && Temp <= ROOM_TEMP_LOWER_C;
    //}
}

public static class Converter
{
    public static double INCH_CM_CONVERT = 2.54;

    public static double InToCm(double inches)
    {
        return inches * INCH_CM_CONVERT;
    }

    public static double CmToIn(double cent)
    {
        return cent / INCH_CM_CONVERT;
    }
}

//public static class NewConv : Converter
//{
//    // this will cause error too, because static classes cannot have SubClasses;
//}



public abstract class Vehicle
{
    public Vehicle() { }
    public string? Model
    {
        get; init;
    }
    public string? Make
    {
        get;
        init;
    }

    public abstract void SoundHorn();
    public abstract int WheelCount
    {
        get;
    }
    public override string ToString()
    {
        return $"{GetType()}: {Make} {Model}, Wheels: {WheelCount}";
    }
}


public class Car : Vehicle
{
    public Car() { }

    public override int WheelCount => 4;
    public override void SoundHorn()
    {
        Console.WriteLine("Beep Beep");
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle() { }

    public override int WheelCount => 2;

    public override void SoundHorn()
    {
        Console.WriteLine("Honk Honk");
    }
}