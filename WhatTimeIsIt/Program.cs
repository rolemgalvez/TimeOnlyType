// Welcome message
Console.WriteLine("What Time Is It");
Console.WriteLine("---------------");
Console.WriteLine();

// Declare variables
string randomTimeRaw = "12:00 PM";
DateTime timeNowRaw = DateTime.Now;
DateTime utcTimeNowRaw = DateTime.UtcNow;

TimeOnly randomTime = TimeOnly.Parse(randomTimeRaw);
TimeOnly timeNow = TimeOnly.FromDateTime(timeNowRaw);
TimeOnly utcTimeNow = TimeOnly.FromDateTime(utcTimeNowRaw);

// Show values
Console.WriteLine($"Random Time (Raw)  : {randomTimeRaw}");
Console.WriteLine($"Random Time        : {randomTime}");
Console.WriteLine();
Console.WriteLine($"Time Now (Raw)     : {timeNowRaw}");
Console.WriteLine($"Time Now           : {timeNow}");
Console.WriteLine();
Console.WriteLine($"UTC Time Now (Raw) : {utcTimeNowRaw}");
Console.WriteLine($"UTC Time Now       : {utcTimeNow}");
Console.ReadLine();