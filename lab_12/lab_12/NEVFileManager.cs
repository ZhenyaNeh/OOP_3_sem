using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace lab_12
{
    class NEVFileManager
    {
        public static void Inspect(string dir)
        {
            NEVLog.WriteInFile($"Дата: {DateTime.Now} \n");
            if (Directory.Exists(dir))
            {
                NEVLog.WriteInFile($"Подкоталоги: ");
                var podDirectory = Directory.GetDirectories(dir);
                foreach (var podDir in podDirectory)
                {
                    NEVLog.WriteInFile(podDir);
                }
                NEVLog.WriteInFile($"Файлы: ");
                var files = Directory.GetFiles(dir);
                foreach (var file in files)
                {
                    NEVLog.WriteInFile(file);
                }
            }
            else
                NEVLog.WriteInFile($"Диск не существует: ");

            string pathDir = "..\\..\\..\\NEV_Inspect";
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
                NEVLog.WriteInFile($"Создана папка: {pathDir} ");
            }

            string pathFile = "..\\..\\..\\NEV_Inspect\\nev_dirInfo.txt";
            if (!File.Exists(pathFile))
            {
                string text = "test some text";
                using (StreamWriter sw = new StreamWriter(pathFile, true))
                {
                    sw.WriteLine(text);
                }

                NEVLog.WriteInFile($"Создали файл: {pathDir}");
            }

            try
            {
                string newPathFile = "..\\..\\..\\NEV_Inspect\\nev_dirInfo_CPY.txt";
                File.Copy(pathFile, newPathFile, true);
                NEVLog.WriteInFile($"Скопировали в новый файл: {newPathFile}");

                if (File.Exists(pathFile))
                {
                    File.Delete(pathFile);
                    NEVLog.WriteInFile($"Предыдущий файл был удален: {newPathFile}\n");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Сообщение 1: {ex.Message}");
            }
            NEVLog.WriteInFile("---------------------------------\n");
        }

        public static void Files(string exten, string path)
        {
            NEVLog.WriteInFile($"Дата: {DateTime.Now}");

            string pathDir = "..\\..\\..\\NEV_Files";
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
                NEVLog.WriteInFile($"Создана папка: {pathDir} ");
            }

            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                foreach (var dir in directory.GetDirectories())
                {
                    var files = dir.GetFiles(exten);

                    foreach (var item in files)
                    {
                        NEVLog.WriteInFile($"Копируем файл \'{item.Name}\' в NEV_Files");
                        string buff = pathDir + "\\" + item.Name;
                        item.CopyTo(buff, true);
                    }
                }

            }

            string pathCPy = "..\\..\\..\\NEV_Inspect\\NEV_Files";
            if (!Directory.Exists(pathCPy))
            {
                Directory.Move(pathDir, pathCPy);
                NEVLog.WriteInFile($"Перемещаем каталог NEV_Files в NEV_Inspect");
            }

            NEVLog.WriteInFile("---------------------------------\n");
        }

        public static void Zip()
        {
            string sourceFolder = "..\\..\\..\\NEV_Inspect\\NEV_Files";
            string zipFile = "..\\..\\..\\try.zip";
            string targetFolder = "..\\..\\..\\NEV_Zip";

            NEVLog.WriteInFile($"Дата: {DateTime.Now}");

            NEVLog.WriteInFile($"Архивирование...");
            if (!File.Exists("..\\..\\..\\try.zip"))
            {
                ZipFile.CreateFromDirectory(sourceFolder, zipFile);
                NEVLog.WriteInFile($"Создан файл try.zip");
                ZipFile.ExtractToDirectory(zipFile, targetFolder);
                NEVLog.WriteInFile($"Распоковываем файл try.zip");
            }

            NEVLog.WriteInFile("---------------------------------\n");
        }
    }
}
