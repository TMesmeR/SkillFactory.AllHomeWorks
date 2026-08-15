using SkillFactory.AllHomeWorks.Moduls;
using YoutubeExplode;

Console.Write("Введите ссылку: ");
string videoUrl = Console.ReadLine();

var youtubeClient = new YoutubeClient();
var invoker = new Invoker();

Console.WriteLine("Выберите действие:");
Console.WriteLine("1.Получить инфо о видео");
Console.WriteLine("2.Загрузить видео");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        invoker.SetCommand(new GetVideoInfoCommand(youtubeClient, videoUrl));
        await invoker.ExecuteCommandAsync();
        break;
    case "2":
        Console.WriteLine("Под каким именем сохранить видео? ");
        string outputFilePath = Console.ReadLine() + ".mp4";
        invoker.SetCommand(new DownloadVideoCommand(youtubeClient, videoUrl, outputFilePath));
        await invoker.ExecuteCommandAsync();
        break;
    default:
        Console.WriteLine("Неверный выбор");
        break;
}