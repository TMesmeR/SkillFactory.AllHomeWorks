string directoryPath = "Folder";

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("Указанная папка не существует.");
    return;
}

try
{
    long initialSize = GetDirectorySize(directoryPath);
    Console.WriteLine($"Размер папки до очистки: {initialSize} байт.");

    int filesDeleted;
    long sizeFreed;
    CleanDirectory(directoryPath, TimeSpan.FromMinutes(30), out filesDeleted, out sizeFreed);

    Console.WriteLine($"Удалено файлов: {filesDeleted}");
    Console.WriteLine($"Освобождено места: {sizeFreed} байт.");

    long finalSize = GetDirectorySize(directoryPath);
    Console.WriteLine($"Размер папки после очистки: {finalSize} байт.");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Ошибка: Нет прав доступа для чтения файлов или папок.");
}
catch (Exception e)
{
    Console.WriteLine($"Произошла непредвиденная ошибка: {e.Message}");
}

long GetDirectorySize(string directoryPath)
{
    long size = 0;


    string[] fileNames = Directory.GetFiles(directoryPath);
    foreach (string fileName in fileNames)
    {
        FileInfo fileInfo = new FileInfo(fileName);
        size += fileInfo.Length;
    }


    string[] subDirectoryNames = Directory.GetDirectories(directoryPath);
    foreach (string subDirectoryName in subDirectoryNames)
    {
        size += GetDirectorySize(subDirectoryName);
    }

    return size;
}

void CleanDirectory(string directoryPath, TimeSpan timeDelete, out int filesDeleted, out long sizeFreed)
{
    DateTime currentTime = DateTime.Now;
    filesDeleted = 0;
    sizeFreed = 0;


    string[] files = Directory.GetFiles(directoryPath);
    foreach (string file in files)
    {
        try
        {
            FileInfo fileInfo = new FileInfo(file);
            if (currentTime - fileInfo.LastAccessTime > timeDelete)
            {
                long fileSize = fileInfo.Length;
                fileInfo.Delete();
                filesDeleted++;
                sizeFreed += fileSize;
                Console.WriteLine($"Файл удален: {file}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Не удалось удалить файл {file}: {e.Message}");
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
                long dirSize = GetDirectorySize(dir);
                dirInfo.Delete(true);
                filesDeleted++;
                sizeFreed += dirSize;
                Console.WriteLine($"Папка удалена: {dir}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Не удалось удалить папку {dir}: {e.Message}");
        }
    }
}