// Welcome message
Console.WriteLine("Just In Time");
Console.WriteLine("------------");
Console.WriteLine();

// Declare variables
string appointmentTimeRaw = "11:00 AM";
DateTime timeNowRaw = DateTime.Now;

TimeOnly appointmentTime = TimeOnly.Parse(appointmentTimeRaw);
TimeOnly timeNow = TimeOnly.FromDateTime(timeNowRaw);

// Show values
Console.WriteLine($"Appointment Time (Raw) : {appointmentTime}");
Console.WriteLine($"Time Now (Raw)         : {timeNowRaw}");
Console.WriteLine();
Console.WriteLine($"Appointment Time       : {appointmentTime}");
Console.WriteLine($"Time Now               : {timeNow}");
Console.ReadLine();