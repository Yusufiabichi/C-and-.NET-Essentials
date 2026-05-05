
Temperature[] temps =
{
    new Temperature(19.1), new Temperature(22.5), new Temperature(15.8), new Temperature(20.2),
    new Temperature(21.3), new Temperature(18.6), new Temperature(23.0), new Temperature(17.3)
};


//Console.WriteLine($"{Temperature.FtoC(72.0):F2}");
//Console.WriteLine($"{Temperature.CtoF(22.0):F2}");

var roomtemps = 0;
foreach(Temperature t in temps)
{
    if (t.IsRoomTemp())
    { 
        roomtemps++;
    }
}
//Console.WriteLine($"Room temp is between {Temperature.ROOM_TEMP_LOWER_C}C and {Temperature.ROOM_TEMP_UPPER_C}C");
//Console.WriteLine($"{roomtemps} measurements are room temperature");


//Console.WriteLine($"{Temperature.IsRoomTemp(22.0)}");
//Console.WriteLine($"{Temperature.IsRoomTemp(17.0)}");


//Console.WriteLine($"There are {Converter.INCH_CM_CONVERT} cm per inch");

//double result = Converter.InToCm(5.0);
//Console.WriteLine(result);

//result = Converter.CmToIn(5.0);
//Console.WriteLine(result);

//Converter conv = new System.Converter(); //this will cause a compiler error;

Car c = new Car() { Make = "Ford", Model = "Escort" };
Motorcycle m = new Motorcycle() { Make = "Trimph", Model = "Thunderbird" };

Console.WriteLine(c);
c.SoundHorn();
Console.WriteLine(m);
m.SoundHorn();
//Vehicle v = new Vehicle();
//Console.WriteLine(v);