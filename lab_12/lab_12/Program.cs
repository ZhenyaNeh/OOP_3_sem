namespace lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NEVDiskInfo.DiskInfo();
                Console.WriteLine("----------------------------------------------");
                NEVFileInfo.FileInfo("..\\..\\..\\..\\..\\12_Потоки_файловая система.pdf");
                Console.WriteLine("----------------------------------------------");
                NEVDirInfo.DirInfo("D:\\University\\OOP");
                Console.WriteLine("----------------------------------------------");

                NEVFileManager.Inspect("..\\..\\..\\");
                NEVFileManager.Files("*.js", "D:\\University\\JS");
                NEVFileManager.Zip();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сообщение: {ex.Message}");
            }

            NEVLog.CheckTime("12/8/2023");
            NEVLog.CheckCount();
            NEVLog.TimeRange(1, 12);
            NEVLog.CheckLastTenSec();
        }
    }
}