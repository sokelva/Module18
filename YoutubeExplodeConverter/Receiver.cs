using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeExplodeConverter
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }

        public void GetVideoInfo(string url)
        {
            YoutubeClient client = new YoutubeClient();
            var info = client.Videos.GetAsync(url).Result;

            Console.WriteLine($"Название: {info.Title}");
            Console.WriteLine($"Продолжительность: {info.Duration}");
            Console.WriteLine($"Автор: {info.Author}");
            Console.ReadKey();
        }

        public void DownLoadVideo(string url, string outputFilePath)
        {
            YoutubeClient client = new YoutubeClient();
            client.Videos.DownloadAsync(url, outputFilePath);

            Console.ReadKey();
        }

    }
}
