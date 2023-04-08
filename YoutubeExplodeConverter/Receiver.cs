using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

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
        }

        public void DownLoadVideo(string url, string outputFilePath)
        {
            YoutubeClient client = new YoutubeClient();
            client.Videos.DownloadAsync(url, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
            //Console.WriteLine("Запущено скачивание файла в течение 2-х минут!!");
            Console.ReadKey();
            Task.WaitAll();
            Console.ReadKey();
        }
    }
}
