using System.Management;

var diskSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

foreach (ManagementObject disk in diskSearcher.Get())
{
    Console.WriteLine($"Модель: {disk["Model"]}");
    long sizeBytes = Convert.ToInt64(disk["Size"]);
    Console.WriteLine($"Размер: {sizeBytes / 1024.0 / 1024 / 1024:F1} ГБ");
}
