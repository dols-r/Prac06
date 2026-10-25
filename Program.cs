using System.Management;

var usbSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE 'USB%'");

Console.WriteLine("Устройства Plug and Play с идентификатором USB:");
foreach (ManagementObject device in usbSearcher.Get())
{
    Console.WriteLine($" - {device["Name"]}");
}

