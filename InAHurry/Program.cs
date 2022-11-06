using System.Globalization;

// Welcome message
Console.WriteLine("In A Hurry");
Console.WriteLine("----------");
Console.WriteLine();

// Declare variables
string meetingTimeRaw = "10:00 PM";
string timeFormat = "hh:mm tt";
string targetTimeFormat = "HH:mm:ss";
CultureInfo timeRule = CultureInfo.InvariantCulture;
DateTime timeNowRaw = DateTime.Now;

TimeOnly meetingTime = TimeOnly.ParseExact(meetingTimeRaw, timeFormat, timeRule);
string meetingTimeNewFormat = meetingTime.ToString(targetTimeFormat);
TimeOnly timeNow = TimeOnly.FromDateTime(timeNowRaw);
string timeNowNewFormat = timeNow.ToString(targetTimeFormat);

// Show values
Console.WriteLine($"Meeting Time (Raw)                 : {meetingTimeRaw}");
Console.WriteLine($"Meeting Time (Raw)'s Format        : {timeFormat}");
Console.WriteLine($"Meeting Time (Raw)'s Target Format : {targetTimeFormat}");
Console.WriteLine($"Time Now  (Raw)                    : {timeNowRaw}");
Console.WriteLine();
Console.WriteLine($"Meeting Time                       : {meetingTimeNewFormat}");
Console.WriteLine($"Time Now                           : {timeNowNewFormat}");
Console.ReadLine();