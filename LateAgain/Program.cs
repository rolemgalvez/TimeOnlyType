// Welcome message
Console.WriteLine("Late Again?");
Console.WriteLine("----------");
Console.WriteLine();

// Declare variables
string agreedTimeRaw = "09:00 AM";
DateTime arrivedTimeRaw = DateTime.Now;

TimeOnly agreedTime = TimeOnly.Parse(agreedTimeRaw);    
TimeOnly arrivedTime = TimeOnly.FromDateTime(arrivedTimeRaw);

// Show values
Console.WriteLine($"Agreed Time (Raw)  : {agreedTimeRaw}");
Console.WriteLine($"Arrived Time (Raw) : {arrivedTimeRaw}");
Console.WriteLine();
Console.WriteLine($"Agreed Time        : {agreedTime}");
Console.WriteLine($"Arrived Time       : {arrivedTime}");
Console.ReadLine();