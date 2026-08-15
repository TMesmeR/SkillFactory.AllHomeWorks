using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SkillFactory.AllHomeWorks.Moduls
{
    internal class DownloadVideoCommand : ICommand
    {
        private readonly YoutubeClient _youtubeClient;
        private readonly string _videoUrl;
        private readonly string _outputFilePath;

        public DownloadVideoCommand(YoutubeClient youtubeClient, string videoUrl, string outputFilePath)
        {
            _youtubeClient = youtubeClient;
            _videoUrl = videoUrl;
            _outputFilePath = outputFilePath;
        }

        public async Task ExecuteAsync()
        {
            await _youtubeClient.Videos.DownloadAsync(_videoUrl, _outputFilePath, builder => builder.SetPreset(ConversionPreset.Fast));
            Console.WriteLine($"Видео сохранено по пути : {Path.GetFullPath (_outputFilePath)}.");
        }
    }
}
