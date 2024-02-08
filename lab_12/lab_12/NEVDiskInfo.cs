using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    public class NEVDiskInfo
    {
        public static void DiskInfo()
        {
            var drives = DriveInfo.GetDrives();
            NEVLog.WriteInFile($"Дата: {DateTime.Now}\n");

            NEVLog.WriteInFile("Информация о дисках!!!\n");

            foreach (var drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                NEVLog.WriteInFile($"Название: {drive.Name}");
                if (drive.IsReady)
                {
                    Console.WriteLine(
                       $"Объем диска: {drive.TotalSize} byte \n" +
                       $"Свободное пространство: {drive.TotalFreeSpace} byte \n" +
                       $"Метка диска: {drive.VolumeLabel} \n" +
                       $"Файловая система: {drive.DriveFormat} \n"
                       );
                    NEVLog.WriteInFile(
                        $"Объем диска: {drive.TotalSize} byte \n" +
                        $"Свободное пространство: {drive.TotalFreeSpace} byte \n" +
                        $"Метка диска: {drive.VolumeLabel} \n" +
                        $"Файловая система: {drive.DriveFormat} \n"
                        );
                }
                Console.WriteLine();

            }
            NEVLog.WriteInFile("\n---------------------------------\n");
        }
    }
}
