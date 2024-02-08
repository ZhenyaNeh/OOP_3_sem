using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class NEVDirInfo
    {
        public static void DirInfo(string DirName)
        {
            var directory = new DirectoryInfo(DirName);
            NEVLog.WriteInFile($"Дата: {DateTime.Now}");

            NEVLog.WriteInFile("Информация о дисках!!!\n");

            NEVLog.WriteInFile($"Информация о папке: {directory.Name}");

            if (directory.Exists)
            {
                var files = directory.GetFiles();
                var podDirectories = directory.GetDirectories();
                Console.WriteLine(
                    $"Количество файлов: {files.Length} \n" +
                    $"Время создания каталога: {directory.CreationTime} \n" +
                    $"Количество подкоталогов: {podDirectories.Length} \n" +
                    $"Список родительских директориев: {directory.Parent} \n"
                    );
                NEVLog.WriteInFile(
                    $"Количество файлов: {files.Length} \n" +
                    $"Время создания каталога: {directory.CreationTime} \n" +
                    $"Количество подкоталогов: {podDirectories.Length} \n" +
                    $"Список родительских директориев: {directory.Parent} \n"
                    );
            }
            NEVLog.WriteInFile("\n---------------------------------\n");
        }
    }
}
