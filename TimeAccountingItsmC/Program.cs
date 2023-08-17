//DateTime departure = new DateTime(2010, 6, 12, 18, 32, 0);
//DateTime deviceAccessTime = new DateTime(2010, 6, 13, 22, 47, 0);

// replace below with the list?

while (true)
{
	Console.WriteLine("Device access month: ");
	var deviceAccessMonth = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Device access day: ");
	var deviceAccessDay = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Device access hour: ");
	var deviceAccessHour = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Device access minute: ");
	var deviceAccessMinute = Int32.Parse(Console.ReadLine());

	Console.WriteLine("Service end month: ");
	var serviceEndMonth = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Service end day: ");
	var serviceEndDay = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Service end hour: ");
	var serviceEndHour = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Service end minute: ");
	var serviceEndMinute = Int32.Parse(Console.ReadLine());




	DateTime serviceEnd = new DateTime(2023, serviceEndMonth, serviceEndDay, serviceEndHour, serviceEndMinute, 0);
	DateTime deviceAccessTime = new DateTime(2023, deviceAccessMonth, deviceAccessDay, deviceAccessHour, deviceAccessMinute, 0);

	TimeSpan timeAccounting = serviceEnd - deviceAccessTime;

	Console.WriteLine($"Time accounting: {timeAccounting.Minutes} \nPress enter to continue.");
	Console.ReadLine(); 
}