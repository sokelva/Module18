using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YoutubeExplodeConverter
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandOne : Command
    {
        
        Receiver receiver;
        public static string VideoUrl = "https://www.youtube.com/watch?v=1La4QzGeaaQ";

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void ConsoleViewer()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
            GetVideoInfo();
        }

        // Скачать
        public override void DownLoadVideo()
        {

        }

        public async Task GetVideoInfo()
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.GetStringAsync(VideoUrl).Wait();
                YoutubeClient client = new YoutubeClient();
                Console.ReadLine();
                var info = await client.Videos.GetAsync("https://www.youtube.com/watch?v=1La4QzGeaaQ");

                
                Console.WriteLine($"Название: {info.Title}");
                Console.WriteLine($"Продолжительность: {info.Duration}");
                Console.WriteLine($"Автор: {info.Author}");
                Console.ReadLine();
            }
        }
    }

}
