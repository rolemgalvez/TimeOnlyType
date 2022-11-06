// Welcome message
Console.WriteLine("Working Time");
Console.WriteLine("------------");
Console.WriteLine();

// Declare variables
string openTimeRaw = "8:00 AM";
string closeTimeRaw = "5:00 PM";
DateTime timeNowRaw = DateTime.Now;

TimeOnly openTime = TimeOnly.Parse(openTimeRaw);
TimeOnly closeTime = TimeOnly.Parse(closeTimeRaw);
TimeOnly timeNow = TimeOnly.FromDateTime(timeNowRaw);

// Show values
Console.WriteLine($"Open Time (Raw)  : {openTimeRaw}");
Console.WriteLine($"Close Time (Raw) : {closeTimeRaw}");
Console.WriteLine($"Time Now (Raw)   : {timeNowRaw}");
Console.WriteLine();
Console.WriteLine($"Open Time        : {openTime}");
Console.WriteLine($"Close Time       : {closeTime}");
Console.WriteLine($"Time Now         : {timeNow}");
Console.ReadLine();