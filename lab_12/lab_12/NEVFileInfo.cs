using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class NEVFileInfo
    {
        public static void FileInfo(string path)
        {
            var fileInfo = new FileInfo(path);
            NEVLog.WriteInFile($"Дата: {DateTime.Now}");
            NEVLog.WriteInFile($"Информация о файле \'{fileInfo.Name}\'");
            if (fileInfo.Exists)
            {
                Console.WriteLine(
                   $"Полный путь: {fileInfo.DirectoryName} \n" +
                   $"Полное имя: {fileInfo.FullName}  \n" +
                   $"Размер: {fileInfo.Length}  \n" +
                   $"Расширение: {fileInfo.Extension} \n" +
                   $"Дата создания: {fileInfo.CreationTime} \n"
                   );
                NEVLog.WriteInFile(
                    $"Полный путь: {fileInfo.DirectoryName} \n" +
                    $"Полное имя: {fileInfo.FullName}  \n" +
                    $"Размер: {fileInfo.Length}  \n" +
                    $"Расширение: {fileInfo.Extension} \n" +
                    $"Дата создания: {fileInfo.CreationTime} \n"
                    );
            }
            NEVLog.WriteInFile("\n---------------------------------\n");
        }
    }
}
