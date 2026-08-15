const string directoryPath = "Folder";

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("Папка не существует");
    return;
}

try
{
    CleanDirectory(directoryPath, TimeSpan.FromMinutes(30));
    Console.WriteLine("Очистка выполнена успешна");
}

catch (UnauthorizedAccessException)
{
    Console.WriteLine("Нет прав");
}
catch(IOException ex)
{
    Console.WriteLine($"Ошибка ввода/выводы : {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Что ж ты натворил...{ex.Message}");
}


void CleanDirectory(string directoryPath, TimeSpan timeDelete)
{
    DateTime currentTime = DateTime.Now;    

    string[] files = Directory.GetFiles(directoryPath);

    foreach(string file in files)
    {
        try
        {
            FileInfo fileInfo = new FileInfo(file);
            if (currentTime - fileInfo.LastAccessTime > timeDelete)
            {
                fileInfo.Delete();
                Console.WriteLine($"Файл удален {file}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Не удалось удалить файл {file}: {ex.Message}");
        }
    }

    string[] directories = Directory.GetDirectories(directoryPath);

    foreach (string dir in directories)
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            if (currentTime - dirInfo.LastAccessTime > timeDelete)
            {
                dirInfo.Delete();
                Console.WriteLine($"Файл удален {dir}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Не удалось удалить файл {dir}: {ex.Message}");
        }
    }
}