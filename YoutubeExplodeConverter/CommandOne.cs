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
        

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void ConsoleViewer(string url)
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
            receiver.GetVideoInfo(url);
        }

        // Скачать
        public override void DownLoadVideo(string url, string outputFilePath)
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
            receiver.DownLoadVideo(url, outputFilePath);
        }
    }
}
